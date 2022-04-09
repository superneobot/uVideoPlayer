using MonoTorrent;
using MonoTorrent.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uVideoPlayer.InputBox;
using Vlc.DotNet.Core;
using Vlc.DotNet.Core.Interops;

namespace uPlayer
{
    public partial class mainform : Form
    {
        public VlcMediaPlayer player;
        public Stream stream;
        public Torrent torrent;
        public TorrentManager manager;
        public ClientEngine engine;
        public List<MediaFile> plist { get; set; }

        private Type Play_type { get; set; }
        private PlayStatus plstatus { get; set; }
        private PLayerStyle plstyle { get; set; }
        private StreamType streamtype { get; set; }
        private PlayingType playingType { get; set; }
        //
        public bool show_main_menu = false;
        public bool show_torrent_status_panel = false;
        public bool show_playlist = false;
        public bool show_settings = false;
        public bool stay_on_top = false;
        public string total;
        public string current;
        public string url_address;
        public string download_dir;
        public float buf_int;
        public double filesize;
        public string file_to_play;
        public int playing_file_index;
        public bool mute = false;
        public string stream_address;
        //Координаты мышки
        private int x = 0; private int y = 0;

        public mainform()
        {
            stream = null;
            engine = new ClientEngine();
            plist = new List<MediaFile>();
            this.DoubleBuffered = true;
            InitializeComponent();
            //player
            var library = new DirectoryInfo(Path.Combine(AppContext.BaseDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
            player = new VlcMediaPlayer(library);
            player.VideoHostControlHandle = viewport.Handle;
            plstyle = PLayerStyle.Normal;
            //player events
            player.Opening += Player_Opening;
            player.Playing += Player_Playing;
            player.Paused += Player_Paused;
            player.Stopped += Player_Stopped;
            player.TimeChanged += Player_TimeChanged;
            player.LengthChanged += Player_LengthChanged;
            player.Buffering += Player_Buffering;
            player.EndReached += Player_EndReached;

        }

        private void Player_EndReached(object sender, VlcMediaPlayerEndReachedEventArgs e)
        {

        }

        private void Player_Buffering(object sender, VlcMediaPlayerBufferingEventArgs e)
        {
            var fbuffer = e.NewCache;
            buf_int = fbuffer;
        }

        public void AddFileToPlist(string filename, string filepath)
        {
            plist.Add(new MediaFile(filename, filepath));
            filelist.Items.Clear();
            foreach (var item in plist)
            {
                filelist.Items.Add(item.Name);
            }
        }


        private void Player_LengthChanged(object sender, VlcMediaPlayerLengthChangedEventArgs e)
        {
            seeker.Maximum = (int)player.Length;
            total = TimeSpan.FromMilliseconds((int)player.Length).ToString(@"hh\:mm\:ss");
            Invoke(new Action(() =>
            {
                total_time.Text = TimeSpan.FromMilliseconds((int)player.Length).ToString(@"hh\:mm\:ss");
            }));
        }

        private void Player_TimeChanged(object sender, VlcMediaPlayerTimeChangedEventArgs e)
        {
            if (Play_type == Type.URL)
            {
                Invoke(new Action(() =>
                {
                    seeker.Enabled = false;
                    current_time.Text = TimeSpan.FromMilliseconds((int)player.Time).ToString(@"hh\:mm\:ss");
                }));
            }

            else if (Play_type == Type.Media | playingType == PlayingType.Streaming | Play_type == Type.Torrent)
            {
                seeker.Value = (int)player.Time;
                current = TimeSpan.FromMilliseconds((int)player.Time).ToString(@"hh\:mm\:ss");
                Invoke(new Action(() =>
                {
                    current_time.Text = TimeSpan.FromMilliseconds((int)player.Time).ToString(@"hh\:mm\:ss");
                }));
            }
        }

        private void Player_Stopped(object sender, VlcMediaPlayerStoppedEventArgs e)
        {
            //plstatus = PlayStatus.Stopping;
            Invoke(new Action(async () =>
            {
                if (Play_type == Type.Media)
                {
                    total_time.Text = "00:00:00";
                    current_time.Text = "00:00:00";
                    //Text = "uVideo Player";
                    seeker.Value = 0;
                    seeker.Enabled = false;
                    plstatus = PlayStatus.Stop;
                }
                if (Play_type == Type.Torrent)
                {
                    total_time.Text = "00:00:00";
                    current_time.Text = "00:00:00";
                    //Text = "uVideo Player";
                    seeker.Value = 0;
                    seeker.Enabled = false;
                    plstatus = PlayStatus.Stopping;
                    await engine.StopAllAsync();
                    await manager.StopAsync();
                    progress.Value = 0;
                    progress.Progress = "0%";
                    filesize = 0.0;
                    file_size.Text = $"Размер файла { filesize.ToString(@"0.0")}Mb";
                    torrent_timer.Stop();
                    plstatus = PlayStatus.Stop;
                    stream = null;
                }
                if (Play_type == Type.URL)
                {
                    total_time.Text = "00:00:00";
                    current_time.Text = "00:00:00";
                    //Text = "uVideo Player";
                    seeker.Value = 0;
                    seeker.Enabled = false;
                    plstatus = PlayStatus.Stop;
                }
            }));
        }

        private void Player_Paused(object sender, VlcMediaPlayerPausedEventArgs e)
        {
            plstatus = PlayStatus.Pause;
        }

        private void Player_Playing(object sender, VlcMediaPlayerPlayingEventArgs e)
        {
            plstatus = PlayStatus.Play;
            Invoke(new Action(() =>
            {
                if (Play_type == Type.Torrent)
                {
                    torrent_timer.Start();
                }
                seeker.Enabled = true;
            }));
        }

        private void Player_Opening(object sender, VlcMediaPlayerOpeningEventArgs e)
        {
            plstatus = PlayStatus.Opening;
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            player.Play();
            pauseMenuItem.Checked = false;
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            if (plstatus == PlayStatus.Play)
            {
                player.Pause();
                pauseMenuItem.Checked = true;
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            player.Stop();
            player.ResetMedia();
        }

        private async void mainform_Load(object sender, EventArgs e)
        {
            player.Video.IsKeyInputEnabled = false;
            player.Video.IsMouseInputEnabled = false;
            download_dir = Properties.Settings.Default.download_directory;
            Task PlayerTask = Task.Run(() =>
            {
                try
                {
                    while (true)
                    {

                        Invoke(new Action(() =>
                        {
                            //Play media file
                            if (plstatus == PlayStatus.Play & Play_type == Type.Media & playingType == PlayingType.Watching & streamtype == StreamType.None)
                            {
                                Text = $"uVideo Player [{plstatus}] [{Play_type}] [{playingType}] [{file_to_play}]";
                            }
                            //Play torrent file
                            if (plstatus == PlayStatus.Play & Play_type == Type.Torrent & playingType == PlayingType.Watching & streamtype == StreamType.None)
                            {
                                Text = $"uVideo Player [{plstatus}] [{Play_type}] [{playingType}] [{file_to_play}]";
                            }
                            //Play URL
                            if (plstatus == PlayStatus.Play & Play_type == Type.URL & playingType == PlayingType.Watching)
                            {
                                Text = $"uVideo Player [{plstatus}] [{Play_type}] [{url_address}]";
                            }
                            //Stream media file
                            if (plstatus == PlayStatus.Play & Play_type == Type.Media & playingType == PlayingType.Streaming & streamtype == StreamType.HTTP)
                            {
                                Text = $"uVideo Player [{plstatus}] [{Play_type}] [{playingType}] [{streamtype}]";
                            }
                            if (plstatus == PlayStatus.Play & Play_type == Type.Media & playingType == PlayingType.Streaming & streamtype == StreamType.RTSP)
                            {
                                Text = $"uVideo Player [{plstatus}] [{Play_type}] [{playingType}] [{streamtype}]";
                            }
                            if (plstatus == PlayStatus.Play & Play_type == Type.Media & playingType == PlayingType.Streaming & streamtype == StreamType.UDP)
                            {
                                Text = $"uVideo Player [{plstatus}] [{Play_type}] [{playingType}] [{streamtype}]";
                            }
                            //Stream torrent file
                            if (plstatus == PlayStatus.Play & Play_type == Type.Torrent & playingType == PlayingType.Streaming & streamtype == StreamType.HTTP)
                            {
                                Text = $"uVideo Player [{plstatus}] [{Play_type}] [{playingType}] [{streamtype}]";
                            }
                            if (plstatus == PlayStatus.Play & Play_type == Type.Torrent & playingType == PlayingType.Streaming & streamtype == StreamType.RTSP)
                            {
                                Text = $"uVideo Player [{plstatus}] [{Play_type}] [{playingType}] [{streamtype}]";
                            }
                            if (plstatus == PlayStatus.Play & Play_type == Type.Torrent & playingType == PlayingType.Streaming & streamtype == StreamType.UDP)
                            {
                                Text = $"uVideo Player [{plstatus}] [{Play_type}] [{playingType}] [{streamtype}]";
                            }
                            //Pause
                            if (plstatus == PlayStatus.Pause)
                            {
                                Text = $"uVideo Player [{plstatus}] [{Play_type}] [{playingType}] [{streamtype}]";
                            }
                            //Connecting
                            if (plstatus == PlayStatus.Connecting)
                            {
                                Text = $"uVideo Player [{plstatus}] [{Play_type}] [{playingType}] [{streamtype}]";
                            }
                            //Opening
                            if (plstatus == PlayStatus.Opening)
                            {
                                Text = $"uVideo Player [{plstatus}] [{Play_type}] [{playingType}] [{streamtype}]";
                            }
                            //Stopping
                            if (plstatus == PlayStatus.Stopping)
                            {
                                Text = $"uVideo Player [{plstatus}] [{Play_type}] [{playingType}] [{streamtype}]";
                            }
                            //Stop
                            if (plstatus == PlayStatus.Stop)
                            {
                                Text = $"uVideo Player [{plstatus}]";
                            }

                            if (engine.IsRunning)
                            {
                                clear_cache.Enabled = false;
                            }
                            else
                            {
                                clear_cache.Enabled = true;
                            }
                        }));
                    }
                }
                catch { }
            });

            show_main_menu = Properties.Settings.Default.show_mainmenu;
            show_menu_ch.Checked = show_main_menu;
            mainmenu.Visible = show_main_menu;

            show_torrent_status_panel = Properties.Settings.Default.show_torrent_status;
            show_torrent_ch.Checked = show_torrent_status_panel;
            status_torrent_panel.Visible = show_torrent_status_panel;

            address.Text = Properties.Settings.Default.address_to_stream;


            await Task.WhenAll(PlayerTask);
        }

        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                tray_icon.ShowBalloonTip(1000, "qwe", "asd", ToolTipIcon.Info);
            }
            // Application.Exit();
        }

        private void open_menu_top_Click(object sender, EventArgs e)
        {
            string[] param = new string[]
             {
                //
             };
            Stream video_file = OpenMediaFile();
           // PlayMediaFile(Type.Media, PlayingType.Watching, StreamType.None, param);
            PlayMedia(Type.Media, PlayingType.Watching, StreamType.None, video_file, param);   
        }

        public void PlayMediaFileFromPlayList(Type type, PlayingType ptype, StreamType stype, string filename)
        {
            Play_type = type;
            playingType = ptype;
            streamtype = stype;
            var file = filename;
            stream = new FileStream(file,
                                    FileMode.Open,
                                    FileAccess.Read,
                                    FileShare.Read);
            player.SetMedia(stream);
            player.Play();
        }

        private void PlayMediaFile(Type type, PlayingType stype, StreamType strtype, string[] param)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Filter = "All media files *.mkv, *.avi, *.mp4, *.mp3|*.mkv;*.avi;*.mp4;*.mp3|MKV *.mkv|*.mkv|Avi video file *.avi|*avi|MP4 video file *.mp4|*.mp4|MP3 Music file *.mp3|*.mp3";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    Play_type = type;
                    playingType = stype;
                    streamtype = strtype;
                    var file = op.FileName;
                    stream = new FileStream(file,
                                            FileMode.Open,
                                            FileAccess.Read,
                                            FileShare.Read);
                    player.SetMedia(stream, param);
                    player.Play();
                    AddFileToPlist(Path.GetFileNameWithoutExtension(file), file);
                }
            }
        }

        private Stream OpenMediaFile()
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Filter = "All media files *.mkv, *.avi, *.mp4, *.mp3|*.mkv;*.avi;*.mp4;*.mp3|MKV *.mkv|*.mkv|Avi video file *.avi|*avi|MP4 video file *.mp4|*.mp4|MP3 Music file *.mp3|*.mp3";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    var file = op.FileName;
                    stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
                    AddFileToPlist(Path.GetFileNameWithoutExtension(file), file);
                }
            }

            return stream;
        }

        private void open_torrent_top_Click(object sender, EventArgs e)
        {
            string[] param = new string[]
             {
                //
             };
            //var path = $"{AppContext.BaseDirectory}/Downloads/";
            if (download_dir == string.Empty)
            {
                SetSaveDir();
                OpenTorrentFile(Type.Torrent, PlayingType.Watching, StreamType.None, download_dir, param);
            }
            else
            {
                OpenTorrentFile(Type.Torrent, PlayingType.Watching, StreamType.None, download_dir, param);
            }

        }

        private async void OpenTorrentFile(Type type, PlayingType stype, StreamType strtype, string savepath, string[] param)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Filter = "Torrent *.torrent|*.torrent";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        playingType = stype;
                        Play_type = type;
                        streamtype = strtype;
                        filesize = 0.0;

                        var file = op.FileName;
                        torrent = await Torrent.LoadAsync(file);
                        manager = await engine.AddStreamingAsync(torrent, savepath);
                        await manager.StartAsync();
                        await manager.WaitForMetadataAsync();
                        file_to_play = torrent.Files[0].Path;
                        plstatus = PlayStatus.Connecting;
                        var kinofile = manager.Files[0];
                        stream = await manager.StreamProvider.CreateStreamAsync(kinofile, System.Threading.CancellationToken.None);
                        filesize = (torrent.Files[0].Length) / 1048576.0;
                        plstatus = PlayStatus.Starting;
                        player.SetMedia(stream, param);
                        player.Play();
                        AddFileToPlist(file_to_play, file);
                    }
                    catch { return; }
                }
            }
        }

        private void exit_menu_top_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void volume_control_Scroll(object sender, ScrollEventArgs e)
        {
            var param = volume_control.Value;
            player.Audio.Volume = (int)param;
            volume_tip.SetToolTip(volume_control, $"{param}%");
            if (param > 90)
            {
                vol_ico.Image = Properties.Resources.icons8_audio_32;
            }
            if (param < 75)
            {
                vol_ico.Image = Properties.Resources.icons8_voice_32;
            }
            if (param < 50)
            {
                vol_ico.Image = Properties.Resources.icons8_low_volume_32;
            }
            if (param > 50 & param < 75)
            {
                vol_ico.Image = Properties.Resources.icons8_voice_32;
            }
            if (param == 0)
            {
                vol_ico.Image = Properties.Resources.icons8_mute_32;
            }
        }

        private void seeker_MouseClick(object sender, MouseEventArgs e)
        {
            long Faktor = (player.Length / seeker.Width);
            player.Time = (e.X * Faktor);
        }

        private void seeker_MouseMove(object sender, MouseEventArgs e)
        {
            long Faktor = (player.Length / seeker.Width);
            var time_pos = Faktor * e.X;
            var time_tip = TimeSpan.FromMilliseconds(time_pos).ToString();
            var index = time_tip.IndexOf('.');
            if (index >= 0)
            {
                time_tip = time_tip.Substring(0, index);
            }

            seeker_tip.SetToolTip(seeker, time_tip);
        }

        private void viewport_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (plstyle == PLayerStyle.Normal)
            {
                plstyle = PLayerStyle.Fullscreen;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                mainmenu.Hide();
                status_torrent_panel.Hide();
                control_panel.Hide();
            }
            else
            {
                plstyle = PLayerStyle.Normal;
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                if (show_torrent_status_panel)
                {
                    status_torrent_panel.Show();
                }
                if (show_main_menu)
                {
                    mainmenu.Show();
                }
                control_panel.Show();
            }
        }

        private void viewport_MouseMove(object sender, MouseEventArgs e)
        {
            if (plstyle == PLayerStyle.Fullscreen)
            {
                control_panel.Hide();
                if (e.Location.X >= 0 && e.Location.Y >= Height - control_panel.Height)
                {
                    if (plstyle == PLayerStyle.Fullscreen)
                    {
                        control_panel.Show();
                    }
                }
            }

            if (e.Location.Y >= 0 && e.Location.X >= Width - play_list_panel.Width)
            {
                // if (plstyle == PLayerStyle.Fullscreen)
                // {
                play_list_panel.Show();
                //}
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }

        private void showMainMenu_Click(object sender, EventArgs e)
        {
            //if (show_main_menu)
            //{
            //    show_main_menu = false;
            //    showmenu.Checked = false;
            //    Properties.Settings.Default.show_mainmenu = show_main_menu;
            //    Properties.Settings.Default.Save();
            //    mainmenu.Hide();
            //}
            //else
            //{
            //    show_main_menu = true;
            //    showmenu.Checked = true;
            //    Properties.Settings.Default.show_mainmenu = show_main_menu;
            //    Properties.Settings.Default.Save();
            //    mainmenu.Show();
            //}
        }

        private void get_video_size(VlcMediaPlayerInstance instance)
        {
            var str = player.Manager.GetMediaPlayerVideoHostHandle(instance);

        }

        private void http_media_Click(object sender, EventArgs e)
        {
            int w = 3840 / 2;
            int h = 1608 / 2;
            streamtype = StreamType.HTTP;
            var http = address.Text;
            Stream video_file = OpenMediaFile();
            string[] param = new string[]
                            {
                        ":sout=#transcode{vcodec=h264,vb=3500,width="+w+",height="+h+",scodec=none}"+
                        ":http{mux=ts, sdp="+http+"}",
                        ":sout-keep",
                        ":no-sout-all"
                            };

            PlayMedia(Type.Media, PlayingType.Streaming, StreamType.HTTP, video_file, param);
            // PlayMediaFile(Type.Media, PlayingType.Streaming, StreamType.HTTP, param);
        }

        private void PlayMedia(Type type, PlayingType stype, StreamType strtype, Stream stream, string[] param)
        {
            if (stream != null)
            {
                player.SetMedia(stream, param);
                player.Play();
            }
        }


        private void rtsp_media_Click(object sender, EventArgs e)
        {
            streamtype = StreamType.RTSP;
            var rtsp = "rtsp://192.168.0.103:8080/";
            string[] param = new string[]
                            {
                        ":sout=#transcode{vcodec=h264,vb=4000,venc=x264{profile=baseline},width=1280,height=720,acodec=mpga,ab=192,channels=2,samplerate=44100,scodec=none}"+
                        ":rtp{mux=ts, sdp="+rtsp+"}",
                        ":sout-keep",
                        ":no-sout-all"
                            };
            PlayMediaFile(Type.Media, PlayingType.Streaming, StreamType.RTSP, param);
        }

        private void udp_media_Click(object sender, EventArgs e)
        {
            streamtype = StreamType.UDP;
            var udp = "";
            InputBoxResult res = InputBox.Show("Пожалуйста, введите адрес и порт \rНапример 192.168.0.103:1234/",
                    "Начало трансляции",
                    "", this.Width, this.Height);
            if (res.ReturnCode == DialogResult.OK)
            {
                udp = res.Text;
            }
            else
            {
                return;
            }
            string[] param = new string[]
                            {
                        ":sout=#transcode{vcodec=h264,vb=2000,venc=x264{profile=baseline},width=1280,height=536,acodec=mpga,ab=192,channels=2,samplerate=44100,scodec=none}"+
                        ":udp{dst="+udp+"}",
                        ":sout-keep",
                        ":no-sout-all"
                            };
            PlayMediaFile(Type.Media, PlayingType.Streaming, StreamType.UDP, param);
        }

        private void open_url_Click(object sender, EventArgs e)
        {
            plstatus = PlayStatus.Connecting;
            url_address = @"http://192.168.0.103:8080/";
            Play_type = Type.URL;
            playingType = PlayingType.Watching;
            player.SetMedia(new Uri(url_address));
            player.Play();
        }

        private void http_torrent_Click(object sender, EventArgs e)
        {
            streamtype = StreamType.HTTP;
            var http = address.Text;
            string[] param = new string[]
                            {
                        ":sout=#transcode{vcodec=h264,vb=4000,venc=x264{profile=baseline},acodec=mpga,ab=192,channels=2,samplerate=44100,scodec=none}"+
                        ":http{mux=ts, sdp="+http+"}",
                        ":sout-keep",
                        ":no-sout-all"
                            };
            if (download_dir == string.Empty)
            {
                SetSaveDir();
                OpenTorrentFile(Type.Torrent, PlayingType.Watching, StreamType.None, download_dir, param);
            }
            else
            {
                OpenTorrentFile(Type.Torrent, PlayingType.Watching, StreamType.None, download_dir, param);
            }
        }

        private void rtsp_torrent_Click(object sender, EventArgs e)
        {
            streamtype = StreamType.RTSP;
            var rtsp = "";
            InputBoxResult res = InputBox.Show("Пожалуйста, введите адрес и порт \rНапример rtsp://192.168.0.103:8080/",
                    "Начало трансляции",
                    "", this.Width, this.Height);
            if (res.ReturnCode == DialogResult.OK)
            {
                rtsp = res.Text;
            }
            else
            {
                return;
            }
            string[] param = new string[]
                            {
                        ":sout=#transcode{vcodec=h264,vb=2000,venc=x264{profile=baseline},width=1280,height=536,acodec=mpga,ab=192,channels=2,samplerate=44100,scodec=none}"+
                        ":rtp{mux=ts, sdp="+rtsp+"}",
                        ":sout-keep",
                        ":no-sout-all"
                            };
            if (download_dir == string.Empty)
            {
                SetSaveDir();
                OpenTorrentFile(Type.Torrent, PlayingType.Watching, StreamType.None, download_dir, param);
            }
            else
            {
                OpenTorrentFile(Type.Torrent, PlayingType.Watching, StreamType.None, download_dir, param);
            }
        }

        private void udp_torrent_Click(object sender, EventArgs e)
        {
            streamtype = StreamType.UDP;
            var udp = "";
            InputBoxResult res = InputBox.Show("Пожалуйста, введите адрес и порт \rНапример 192.168.0.103:1234/",
                    "Начало трансляции",
                    "", this.Width, this.Height);
            if (res.ReturnCode == DialogResult.OK)
            {
                udp = res.Text;
            }
            else
            {
                return;
            }
            string[] param = new string[]
                            {
                        ":sout=#transcode{vcodec=h264,vb=2000,venc=x264{profile=baseline},width=1280,height=536,acodec=mpga,ab=192,channels=2,samplerate=44100,scodec=none}"+
                        ":udp{dst="+udp+"}",
                        ":sout-keep",
                        ":no-sout-all"
                            };
            if (download_dir == string.Empty)
            {
                SetSaveDir();
                OpenTorrentFile(Type.Torrent, PlayingType.Watching, StreamType.None, download_dir, param);
            }
            else
            {
                OpenTorrentFile(Type.Torrent, PlayingType.Watching, StreamType.None, download_dir, param);
            }
        }

        private void torrent_timer_Tick(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(1024);
            sb.Remove(0, sb.Length);

            Invoke(new Action(() => { file_size.Text = $"Размер файла {filesize.ToString(@"0.0")} Mb"; }));
            Invoke(new Action(delegate { progress.Value = (int)manager.Progress; }));
            Invoke(new Action(delegate { progress.Progress = $"{(int)manager.Progress}%"; }));
            Invoke(new Action(delegate { buffer.Text = $"Буферизация {buf_int.ToString(@"0.0")}%"; }));
            Invoke(new Action(delegate { speed.Text = AppendFormat(sb, $"{engine.TotalDownloadSpeed / 1024.0:0.00}kB/sec ↓ / {engine.TotalUploadSpeed / 1024.0:0.00}kB/sec ↑"); }));
        }
        string AppendFormat(StringBuilder sb, string str, params object[] formatting)
        {
            if (formatting != null && formatting.Length > 0)
                sb.AppendFormat(str, formatting);
            else
                sb.Append(str);
            sb.AppendLine();

            return str;
        }

        private void view_torrent_status_panel_Click(object sender, EventArgs e)
        {
            //if (show_torrent_status_panel)
            //{
            //    show_torrent_status_panel = false;
            //    view_torrent_status_panel.Checked = false;
            //    Properties.Settings.Default.show_torrent_status = show_torrent_status_panel;
            //    Properties.Settings.Default.Save();
            //    status_torrent_panel.Hide();
            //}
            //else
            //{
            //    show_torrent_status_panel = true;
            //    view_torrent_status_panel.Checked = true;
            //    Properties.Settings.Default.show_torrent_status = show_torrent_status_panel;
            //    Properties.Settings.Default.Save();
            //    status_torrent_panel.Show();
            //}
        }

        private void choose_folder_Click(object sender, EventArgs e)
        {
           // SetSaveDir();
        }

        private void SetSaveDir()
        {

            using (FolderBrowserDialog fb = new FolderBrowserDialog())
            {
                fb.Description = "Выбор папки для сохранения фильмов полученных через торрент.";
                fb.ShowNewFolderButton = true;
                if (fb.ShowDialog() == DialogResult.OK)
                {
                    var dir = fb.SelectedPath;
                    download_dir = @dir + @"\";
                    Properties.Settings.Default.download_directory = download_dir;
                    Properties.Settings.Default.Save();

                    MessageBox.Show(this, $"Директория для сохранения загруженных видео выбрана.\r{download_dir}", "uVideo Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void clear_cache_Click(object sender, EventArgs e)
        {
            //var dir = $@"{AppContext.BaseDirectory}cache\";
            //if (Directory.Exists(dir))
            //{
            //    var result = MessageBox.Show(this, "Очистить папку с кэшем?", "uVideo Player", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {
            //        Directory.Delete(dir, true);
            //    }
            //}
            //else
            //{
            //    Directory.CreateDirectory(dir);
            //}
        }

        private void playlist_menu_Click(object sender, EventArgs e)
        {
            if (!show_playlist)
            {
                show_playlist = true;
                play_list_panel.Show();
            }
            else
            {
                show_playlist = false;
                play_list_panel.Hide();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Multiselect = true;
                if (op.ShowDialog() == DialogResult.OK)
                {
                    var files = op.FileNames;
                    for (int i = 0; i < files.Length; i++)
                    {
                        AddFileToPlist(Path.GetFileNameWithoutExtension(files[i]), files[i]);
                    }

                }
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            var index = filelist.Items.IndexOf(filelist.SelectedItems[0]);
            filelist.Items.RemoveAt(index);
            plist.RemoveAt(index);
        }

        private void filelist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (filelist.SelectedIndex >= 0)
            {
                var index = filelist.Items.IndexOf(filelist.SelectedItems[0]);
                //MessageBox.Show(plist[index].Path);
                var file = plist[index].Path;
                if (!file.Contains(".torrent"))
                {
                    if (engine.IsRunning)
                    {
                        Task.Run(async () =>
                        {
                            await engine.StopAllAsync();
                            await manager.StopAsync();
                        });
                    }
                    PlayMediaFileFromPlayList(Type.Media, PlayingType.Watching, StreamType.None, file);
                    playing_file_index = index;
                }
                if (file.Contains(".torrent"))
                {
                    PlayTorrentFileFromPlaylist(Type.Torrent, PlayingType.Watching, StreamType.None, file);
                }
                file_to_play = plist[index].Name;
            }
        }

        private async void PlayTorrentFileFromPlaylist(Type type, PlayingType ptype, StreamType stype, string torrent_file)
        {
            Play_type = type;
            playingType = ptype;
            streamtype = stype;
            try
            {
                var file = torrent_file;
                torrent = await Torrent.LoadAsync(file);
                manager = await engine.AddStreamingAsync(torrent, download_dir);
                await manager.StartAsync();
                await manager.WaitForMetadataAsync();
                file_to_play = torrent.Files[0].Path;
                plstatus = PlayStatus.Connecting;
                var kinofile = manager.Files[0];
                stream = await manager.StreamProvider.CreateStreamAsync(kinofile, System.Threading.CancellationToken.None);
                filesize = (torrent.Files[0].Length) / 1048576.0;
                plstatus = PlayStatus.Starting;
                player.SetMedia(stream);
                player.Play();
            }
            catch { }
        }

        private void play_list_panel_MouseLeave(object sender, EventArgs e)
        {
            play_list_panel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plist.Clear();
            filelist.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Next();
        }

        public void Next()
        {
            string file;
            try
            {
                playing_file_index++;
                file = plist[playing_file_index].Path;
                PlayMediaFileFromPlayList(Type.Media, PlayingType.Watching, StreamType.None, file);
                file_to_play = plist[playing_file_index].Name;
                filelist.SelectedItem = filelist.Items[playing_file_index];

                if (playing_file_index == filelist.Items.Count - 1)
                    playing_file_index = -1;
            }
            catch
            {
                //
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void vol_ico_Click(object sender, EventArgs e)
        {
            if (!mute)
            {
                mute = true;
                vol_ico.Image = Properties.Resources.icons8_mute_32;
                volume_control.Value = 0;
                player.Audio.Volume = 0;
            }
            else
            {
                mute = false;
                vol_ico.Image = Properties.Resources.icons8_audio_32;
                volume_control.Value = 100;
                player.Audio.Volume = 100;
            }
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            player.Time += 10000;
        }

        private void cast_btn_Click(object sender, EventArgs e)
        {
            http_media.PerformClick();
        }

        private void tray_icon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void address_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    Properties.Settings.Default.address_to_stream = address.Text;
            //    Properties.Settings.Default.Save();
            //}
        }

        private void settings_menu_Click(object sender, EventArgs e)
        {
            if (!show_settings)
            {
                show_settings = true;
                settings_panel.Show();
            }
            else
            {
                show_settings = false;
                settings_panel.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void choose_savedir_btn_Click(object sender, EventArgs e)
        {
            SetSaveDir();
        }

        private void clear_cache_btn_Click(object sender, EventArgs e)
        {
            var dir = $@"{AppContext.BaseDirectory}cache\";
            if (Directory.Exists(dir))
            {
                var result = MessageBox.Show(this, "Очистить папку с кэшем?", "uVideo Player", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Directory.Delete(dir, true);
                }
                MessageBox.Show(this,"Готово","uVideo Player",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Directory.CreateDirectory(dir);
            }
        }

        private void show_torrent_ch_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void show_torrent_ch_Click(object sender, EventArgs e)
        {
            if (show_torrent_status_panel)
            {
                show_torrent_status_panel = false;
                show_torrent_ch.Checked = false;
                Properties.Settings.Default.show_torrent_status = show_torrent_status_panel;
                Properties.Settings.Default.Save();
                status_torrent_panel.Hide();
            }
            else
            {
                show_torrent_status_panel = true;
                show_torrent_ch.Checked = true;
                Properties.Settings.Default.show_torrent_status = show_torrent_status_panel;
                Properties.Settings.Default.Save();
                status_torrent_panel.Show();
            }
        }

        private void show_menu_ch_Click(object sender, EventArgs e)
        {
            if (show_main_menu)
            {
                show_main_menu = false;
                show_menu_ch.Checked = false;
                Properties.Settings.Default.show_mainmenu = show_main_menu;
                Properties.Settings.Default.Save();
                mainmenu.Hide();
            }
            else
            {
                show_main_menu = true;
                show_menu_ch.Checked = true;
                Properties.Settings.Default.show_mainmenu = show_main_menu;
                Properties.Settings.Default.Save();
                mainmenu.Show();
            }
        }

        private void address_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Properties.Settings.Default.address_to_stream = address_box.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show(this,$"Адрес для трансляции {address_box.Text}","uVideo Player",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            show_settings = false;
            settings_panel.Hide();
        }

        private void compact_view_Click(object sender, EventArgs e)
        {
            if (plstyle == PLayerStyle.Normal)
            {
                plstyle = PLayerStyle.Compact;
                compact_view.Checked = true;
                control_panel.Hide();
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                plstyle = PLayerStyle.Normal;
                compact_view.Checked = false;
                control_panel.Show();
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void viewport_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void top_on_screen_Click(object sender, EventArgs e)
        {
            if (!stay_on_top)
            {
                top_on_screen.Checked = true;
                stay_on_top = true;
                TopMost = true; 
            }
            else
            {
                top_on_screen.Checked = false;
                stay_on_top = false;
                TopMost = false;
            }
        }
    }
}
