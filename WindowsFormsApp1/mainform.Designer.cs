namespace uPlayer
{
    partial class mainform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open_menu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.open_torrent_top = new System.Windows.Forms.ToolStripMenuItem();
            this.stream_menu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_menu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.control_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.total_time = new System.Windows.Forms.Label();
            this.current_time = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.seeker = new ColorSlider.ColorSlider();
            this.control_player = new System.Windows.Forms.Panel();
            this.cast_panel = new System.Windows.Forms.Panel();
            this.cast_btn = new System.Windows.Forms.Button();
            this.forward_panel = new System.Windows.Forms.Panel();
            this.forward_btn = new System.Windows.Forms.Button();
            this.next_panel = new System.Windows.Forms.Panel();
            this.next_btn = new System.Windows.Forms.Button();
            this.stop_panel = new System.Windows.Forms.Panel();
            this.stop_btn = new System.Windows.Forms.Button();
            this.pause_panel = new System.Windows.Forms.Panel();
            this.pause_btn = new System.Windows.Forms.Button();
            this.play_panel = new System.Windows.Forms.Panel();
            this.play_btn = new System.Windows.Forms.Button();
            this.volume_panel = new System.Windows.Forms.Panel();
            this.vol_pan = new System.Windows.Forms.Panel();
            this.volume_control = new ColorSlider.ColorSlider();
            this.vol_ico_panel = new System.Windows.Forms.Panel();
            this.vol_ico = new System.Windows.Forms.Button();
            this.player_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlist_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.http_media = new System.Windows.Forms.ToolStripMenuItem();
            this.rtsp_media = new System.Windows.Forms.ToolStripMenuItem();
            this.udp_media = new System.Windows.Forms.ToolStripMenuItem();
            this.playTorrent = new System.Windows.Forms.ToolStripMenuItem();
            this.streamTorrent = new System.Windows.Forms.ToolStripMenuItem();
            this.http_torrent = new System.Windows.Forms.ToolStripMenuItem();
            this.rtsp_torrent = new System.Windows.Forms.ToolStripMenuItem();
            this.udp_torrent = new System.Windows.Forms.ToolStripMenuItem();
            this.open_url = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settings_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.showmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.view_torrent_status_panel = new System.Windows.Forms.ToolStripMenuItem();
            this.choose_folder = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_cache = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.address = new System.Windows.Forms.ToolStripTextBox();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.seeker_tip = new System.Windows.Forms.ToolTip(this.components);
            this.volume_tip = new System.Windows.Forms.ToolTip(this.components);
            this.status_torrent_panel = new System.Windows.Forms.Panel();
            this.file_size = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.buffer = new System.Windows.Forms.Label();
            this.progress = new MyProgressBar.MyProgressBar();
            this.viewport = new System.Windows.Forms.Panel();
            this.torrent_timer = new System.Windows.Forms.Timer(this.components);
            this.play_list_panel = new System.Windows.Forms.Panel();
            this.filelist = new uPlayer.mListBox();
            this.plist_control_panel = new System.Windows.Forms.Panel();
            this.clear_btn_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.del_btn_panel = new System.Windows.Forms.Panel();
            this.del_btn = new System.Windows.Forms.Button();
            this.add_btn_pan = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Button();
            this.plist_top_panel = new System.Windows.Forms.Panel();
            this.pl_caption = new System.Windows.Forms.Label();
            this.tray_icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.settings_panel = new System.Windows.Forms.Panel();
            this.apply_btn = new System.Windows.Forms.Button();
            this.address_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clear_cache_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.choose_savedir_btn = new System.Windows.Forms.Button();
            this.show_torrent_ch = new System.Windows.Forms.CheckBox();
            this.show_menu_ch = new System.Windows.Forms.CheckBox();
            this.mListBox1 = new uPlayer.mListBox();
            this.pr_top_panel = new System.Windows.Forms.Panel();
            this.pr_captions = new System.Windows.Forms.Label();
            this.compact_view = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.top_on_screen = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmenu.SuspendLayout();
            this.control_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.control_player.SuspendLayout();
            this.cast_panel.SuspendLayout();
            this.forward_panel.SuspendLayout();
            this.next_panel.SuspendLayout();
            this.stop_panel.SuspendLayout();
            this.pause_panel.SuspendLayout();
            this.play_panel.SuspendLayout();
            this.volume_panel.SuspendLayout();
            this.vol_pan.SuspendLayout();
            this.vol_ico_panel.SuspendLayout();
            this.player_menu.SuspendLayout();
            this.status_torrent_panel.SuspendLayout();
            this.play_list_panel.SuspendLayout();
            this.plist_control_panel.SuspendLayout();
            this.clear_btn_panel.SuspendLayout();
            this.del_btn_panel.SuspendLayout();
            this.add_btn_pan.SuspendLayout();
            this.plist_top_panel.SuspendLayout();
            this.settings_panel.SuspendLayout();
            this.pr_top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(777, 24);
            this.mainmenu.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_menu_top,
            this.open_torrent_top,
            this.stream_menu_top,
            this.exit_menu_top});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // open_menu_top
            // 
            this.open_menu_top.Name = "open_menu_top";
            this.open_menu_top.Size = new System.Drawing.Size(142, 22);
            this.open_menu_top.Text = "Open";
            this.open_menu_top.Click += new System.EventHandler(this.open_menu_top_Click);
            // 
            // open_torrent_top
            // 
            this.open_torrent_top.Name = "open_torrent_top";
            this.open_torrent_top.Size = new System.Drawing.Size(142, 22);
            this.open_torrent_top.Text = "Open torrent";
            this.open_torrent_top.Click += new System.EventHandler(this.open_torrent_top_Click);
            // 
            // stream_menu_top
            // 
            this.stream_menu_top.Name = "stream_menu_top";
            this.stream_menu_top.Size = new System.Drawing.Size(142, 22);
            this.stream_menu_top.Text = "Stream";
            // 
            // exit_menu_top
            // 
            this.exit_menu_top.Name = "exit_menu_top";
            this.exit_menu_top.Size = new System.Drawing.Size(142, 22);
            this.exit_menu_top.Text = "Exit";
            this.exit_menu_top.Click += new System.EventHandler(this.exit_menu_top_Click);
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.control_panel.Controls.Add(this.panel2);
            this.control_panel.Controls.Add(this.control_player);
            this.control_panel.Controls.Add(this.volume_panel);
            this.control_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.control_panel.Location = new System.Drawing.Point(0, 420);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(777, 46);
            this.control_panel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(216, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 46);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.total_time);
            this.panel4.Controls.Add(this.current_time);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 26);
            this.panel4.TabIndex = 1;
            // 
            // total_time
            // 
            this.total_time.Dock = System.Windows.Forms.DockStyle.Right;
            this.total_time.Location = new System.Drawing.Point(307, 0);
            this.total_time.Name = "total_time";
            this.total_time.Size = new System.Drawing.Size(54, 26);
            this.total_time.TabIndex = 1;
            this.total_time.Text = "00:00:00";
            this.total_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // current_time
            // 
            this.current_time.Dock = System.Windows.Forms.DockStyle.Left;
            this.current_time.Location = new System.Drawing.Point(0, 0);
            this.current_time.Name = "current_time";
            this.current_time.Size = new System.Drawing.Size(52, 26);
            this.current_time.TabIndex = 0;
            this.current_time.Text = "00:00:00";
            this.current_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.seeker);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 20);
            this.panel3.TabIndex = 0;
            // 
            // seeker
            // 
            this.seeker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.seeker.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.seeker.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.seeker.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.seeker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seeker.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.seeker.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(208)))));
            this.seeker.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.seeker.Enabled = false;
            this.seeker.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.seeker.ForeColor = System.Drawing.Color.White;
            this.seeker.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.seeker.Location = new System.Drawing.Point(0, 0);
            this.seeker.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seeker.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seeker.Name = "seeker";
            this.seeker.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.seeker.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.seeker.ShowDivisionsText = true;
            this.seeker.ShowSmallScale = false;
            this.seeker.Size = new System.Drawing.Size(361, 20);
            this.seeker.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seeker.TabIndex = 0;
            this.seeker.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.seeker.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.seeker.ThumbRoundRectSize = new System.Drawing.Size(10, 10);
            this.seeker.ThumbSize = new System.Drawing.Size(10, 10);
            this.seeker.TickAdd = 0F;
            this.seeker.TickColor = System.Drawing.Color.White;
            this.seeker.TickDivide = 0F;
            this.seeker.TickStyle = System.Windows.Forms.TickStyle.None;
            this.seeker.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seeker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.seeker_MouseClick);
            this.seeker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.seeker_MouseMove);
            // 
            // control_player
            // 
            this.control_player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.control_player.Controls.Add(this.cast_panel);
            this.control_player.Controls.Add(this.forward_panel);
            this.control_player.Controls.Add(this.next_panel);
            this.control_player.Controls.Add(this.stop_panel);
            this.control_player.Controls.Add(this.pause_panel);
            this.control_player.Controls.Add(this.play_panel);
            this.control_player.Dock = System.Windows.Forms.DockStyle.Left;
            this.control_player.Location = new System.Drawing.Point(0, 0);
            this.control_player.Name = "control_player";
            this.control_player.Padding = new System.Windows.Forms.Padding(6);
            this.control_player.Size = new System.Drawing.Size(216, 46);
            this.control_player.TabIndex = 7;
            // 
            // cast_panel
            // 
            this.cast_panel.Controls.Add(this.cast_btn);
            this.cast_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cast_panel.Location = new System.Drawing.Point(176, 6);
            this.cast_panel.Name = "cast_panel";
            this.cast_panel.Padding = new System.Windows.Forms.Padding(1);
            this.cast_panel.Size = new System.Drawing.Size(34, 34);
            this.cast_panel.TabIndex = 11;
            // 
            // cast_btn
            // 
            this.cast_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.cast_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cast_btn.FlatAppearance.BorderSize = 0;
            this.cast_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cast_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.cast_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cast_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cast_btn.Image = global::uPlayer.Properties.Resources.icons8_chromecast_cast_button_32;
            this.cast_btn.Location = new System.Drawing.Point(1, 1);
            this.cast_btn.Name = "cast_btn";
            this.cast_btn.Size = new System.Drawing.Size(32, 32);
            this.cast_btn.TabIndex = 6;
            this.cast_btn.UseVisualStyleBackColor = false;
            this.cast_btn.Click += new System.EventHandler(this.cast_btn_Click);
            // 
            // forward_panel
            // 
            this.forward_panel.Controls.Add(this.forward_btn);
            this.forward_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.forward_panel.Location = new System.Drawing.Point(142, 6);
            this.forward_panel.Name = "forward_panel";
            this.forward_panel.Padding = new System.Windows.Forms.Padding(1);
            this.forward_panel.Size = new System.Drawing.Size(34, 34);
            this.forward_panel.TabIndex = 10;
            // 
            // forward_btn
            // 
            this.forward_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.forward_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forward_btn.FlatAppearance.BorderSize = 0;
            this.forward_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.forward_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.forward_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forward_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forward_btn.Image = global::uPlayer.Properties.Resources.icons8_fast_forward_32;
            this.forward_btn.Location = new System.Drawing.Point(1, 1);
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Size = new System.Drawing.Size(32, 32);
            this.forward_btn.TabIndex = 6;
            this.forward_btn.UseVisualStyleBackColor = false;
            this.forward_btn.Click += new System.EventHandler(this.forward_btn_Click);
            // 
            // next_panel
            // 
            this.next_panel.Controls.Add(this.next_btn);
            this.next_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.next_panel.Location = new System.Drawing.Point(108, 6);
            this.next_panel.Name = "next_panel";
            this.next_panel.Padding = new System.Windows.Forms.Padding(1);
            this.next_panel.Size = new System.Drawing.Size(34, 34);
            this.next_panel.TabIndex = 9;
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.next_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.next_btn.FlatAppearance.BorderSize = 0;
            this.next_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.next_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next_btn.Image = global::uPlayer.Properties.Resources.icons8_end_32;
            this.next_btn.Location = new System.Drawing.Point(1, 1);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(32, 32);
            this.next_btn.TabIndex = 6;
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // stop_panel
            // 
            this.stop_panel.Controls.Add(this.stop_btn);
            this.stop_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.stop_panel.Location = new System.Drawing.Point(74, 6);
            this.stop_panel.Name = "stop_panel";
            this.stop_panel.Padding = new System.Windows.Forms.Padding(1);
            this.stop_panel.Size = new System.Drawing.Size(34, 34);
            this.stop_panel.TabIndex = 8;
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.stop_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stop_btn.FlatAppearance.BorderSize = 0;
            this.stop_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.stop_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop_btn.Image = global::uPlayer.Properties.Resources.icons8_stop_32;
            this.stop_btn.Location = new System.Drawing.Point(1, 1);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(32, 32);
            this.stop_btn.TabIndex = 6;
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // pause_panel
            // 
            this.pause_panel.Controls.Add(this.pause_btn);
            this.pause_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pause_panel.Location = new System.Drawing.Point(40, 6);
            this.pause_panel.Name = "pause_panel";
            this.pause_panel.Padding = new System.Windows.Forms.Padding(1);
            this.pause_panel.Size = new System.Drawing.Size(34, 34);
            this.pause_panel.TabIndex = 7;
            // 
            // pause_btn
            // 
            this.pause_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.pause_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pause_btn.FlatAppearance.BorderSize = 0;
            this.pause_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.pause_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.pause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pause_btn.Image = global::uPlayer.Properties.Resources.icons8_pause_32;
            this.pause_btn.Location = new System.Drawing.Point(1, 1);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(32, 32);
            this.pause_btn.TabIndex = 5;
            this.pause_btn.UseVisualStyleBackColor = false;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // play_panel
            // 
            this.play_panel.Controls.Add(this.play_btn);
            this.play_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.play_panel.Location = new System.Drawing.Point(6, 6);
            this.play_panel.Name = "play_panel";
            this.play_panel.Padding = new System.Windows.Forms.Padding(1);
            this.play_panel.Size = new System.Drawing.Size(34, 34);
            this.play_panel.TabIndex = 6;
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.play_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.play_btn.FlatAppearance.BorderSize = 0;
            this.play_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.play_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.play_btn.Image = global::uPlayer.Properties.Resources.icons8_play_32;
            this.play_btn.Location = new System.Drawing.Point(1, 1);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(32, 32);
            this.play_btn.TabIndex = 4;
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // volume_panel
            // 
            this.volume_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.volume_panel.Controls.Add(this.vol_pan);
            this.volume_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.volume_panel.Location = new System.Drawing.Point(577, 0);
            this.volume_panel.Name = "volume_panel";
            this.volume_panel.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.volume_panel.Size = new System.Drawing.Size(200, 46);
            this.volume_panel.TabIndex = 4;
            // 
            // vol_pan
            // 
            this.vol_pan.Controls.Add(this.volume_control);
            this.vol_pan.Controls.Add(this.vol_ico_panel);
            this.vol_pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vol_pan.Location = new System.Drawing.Point(12, 6);
            this.vol_pan.Name = "vol_pan";
            this.vol_pan.Padding = new System.Windows.Forms.Padding(1);
            this.vol_pan.Size = new System.Drawing.Size(176, 34);
            this.vol_pan.TabIndex = 0;
            // 
            // volume_control
            // 
            this.volume_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.volume_control.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.volume_control.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.volume_control.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.volume_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volume_control.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.volume_control.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(208)))));
            this.volume_control.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.volume_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.volume_control.ForeColor = System.Drawing.Color.White;
            this.volume_control.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.volume_control.Location = new System.Drawing.Point(33, 1);
            this.volume_control.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.volume_control.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.volume_control.Name = "volume_control";
            this.volume_control.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.volume_control.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.volume_control.ShowDivisionsText = true;
            this.volume_control.ShowSmallScale = false;
            this.volume_control.Size = new System.Drawing.Size(142, 32);
            this.volume_control.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.volume_control.TabIndex = 4;
            this.volume_control.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.volume_control.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.volume_control.ThumbRoundRectSize = new System.Drawing.Size(10, 10);
            this.volume_control.ThumbSize = new System.Drawing.Size(10, 10);
            this.volume_control.TickAdd = 0F;
            this.volume_control.TickColor = System.Drawing.Color.White;
            this.volume_control.TickDivide = 0F;
            this.volume_control.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume_control.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.volume_control.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volume_control_Scroll);
            // 
            // vol_ico_panel
            // 
            this.vol_ico_panel.Controls.Add(this.vol_ico);
            this.vol_ico_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.vol_ico_panel.Location = new System.Drawing.Point(1, 1);
            this.vol_ico_panel.Name = "vol_ico_panel";
            this.vol_ico_panel.Size = new System.Drawing.Size(32, 32);
            this.vol_ico_panel.TabIndex = 3;
            // 
            // vol_ico
            // 
            this.vol_ico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vol_ico.FlatAppearance.BorderSize = 0;
            this.vol_ico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.vol_ico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.vol_ico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vol_ico.Image = global::uPlayer.Properties.Resources.icons8_audio_32;
            this.vol_ico.Location = new System.Drawing.Point(0, 0);
            this.vol_ico.Name = "vol_ico";
            this.vol_ico.Size = new System.Drawing.Size(32, 32);
            this.vol_ico.TabIndex = 0;
            this.vol_ico.UseVisualStyleBackColor = true;
            this.vol_ico.Click += new System.EventHandler(this.vol_ico_Click);
            // 
            // player_menu
            // 
            this.player_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playMenuItem,
            this.pauseMenuItem,
            this.stopMenuItem,
            this.playlist_menu,
            this.toolStripSeparator1,
            this.openVideoToolStripMenuItem,
            this.streamMenu,
            this.playTorrent,
            this.streamTorrent,
            this.open_url,
            this.toolStripSeparator2,
            this.compact_view,
            this.top_on_screen,
            this.toolStripSeparator4,
            this.settings_menu,
            this.exit});
            this.player_menu.Name = "player_menu";
            this.player_menu.Size = new System.Drawing.Size(205, 330);
            // 
            // playMenuItem
            // 
            this.playMenuItem.Name = "playMenuItem";
            this.playMenuItem.Size = new System.Drawing.Size(204, 22);
            this.playMenuItem.Text = "Воспроизведение";
            this.playMenuItem.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // pauseMenuItem
            // 
            this.pauseMenuItem.Name = "pauseMenuItem";
            this.pauseMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pauseMenuItem.Text = "Пауза";
            this.pauseMenuItem.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // stopMenuItem
            // 
            this.stopMenuItem.Name = "stopMenuItem";
            this.stopMenuItem.Size = new System.Drawing.Size(204, 22);
            this.stopMenuItem.Text = "Стоп";
            this.stopMenuItem.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // playlist_menu
            // 
            this.playlist_menu.Name = "playlist_menu";
            this.playlist_menu.Size = new System.Drawing.Size(204, 22);
            this.playlist_menu.Text = "Список файлов";
            this.playlist_menu.Click += new System.EventHandler(this.playlist_menu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // openVideoToolStripMenuItem
            // 
            this.openVideoToolStripMenuItem.Name = "openVideoToolStripMenuItem";
            this.openVideoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.openVideoToolStripMenuItem.Text = "Открыть видео";
            this.openVideoToolStripMenuItem.Click += new System.EventHandler(this.open_menu_top_Click);
            // 
            // streamMenu
            // 
            this.streamMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.http_media,
            this.rtsp_media,
            this.udp_media});
            this.streamMenu.Name = "streamMenu";
            this.streamMenu.Size = new System.Drawing.Size(204, 22);
            this.streamMenu.Text = "Транслировать видео";
            // 
            // http_media
            // 
            this.http_media.Name = "http_media";
            this.http_media.Size = new System.Drawing.Size(180, 22);
            this.http_media.Text = "Видео через HTTP";
            this.http_media.Click += new System.EventHandler(this.http_media_Click);
            // 
            // rtsp_media
            // 
            this.rtsp_media.Name = "rtsp_media";
            this.rtsp_media.Size = new System.Drawing.Size(180, 22);
            this.rtsp_media.Text = "Видео через RTSP";
            this.rtsp_media.Visible = false;
            this.rtsp_media.Click += new System.EventHandler(this.rtsp_media_Click);
            // 
            // udp_media
            // 
            this.udp_media.Name = "udp_media";
            this.udp_media.Size = new System.Drawing.Size(180, 22);
            this.udp_media.Text = "Видео через UDP";
            this.udp_media.Visible = false;
            this.udp_media.Click += new System.EventHandler(this.udp_media_Click);
            // 
            // playTorrent
            // 
            this.playTorrent.Name = "playTorrent";
            this.playTorrent.Size = new System.Drawing.Size(204, 22);
            this.playTorrent.Text = "Открыть торрент";
            this.playTorrent.Click += new System.EventHandler(this.open_torrent_top_Click);
            // 
            // streamTorrent
            // 
            this.streamTorrent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.http_torrent,
            this.rtsp_torrent,
            this.udp_torrent});
            this.streamTorrent.Name = "streamTorrent";
            this.streamTorrent.Size = new System.Drawing.Size(204, 22);
            this.streamTorrent.Text = "Транслировать торрент";
            // 
            // http_torrent
            // 
            this.http_torrent.Name = "http_torrent";
            this.http_torrent.Size = new System.Drawing.Size(219, 22);
            this.http_torrent.Text = "Торрент видео через HTTP";
            this.http_torrent.Click += new System.EventHandler(this.http_torrent_Click);
            // 
            // rtsp_torrent
            // 
            this.rtsp_torrent.Name = "rtsp_torrent";
            this.rtsp_torrent.Size = new System.Drawing.Size(219, 22);
            this.rtsp_torrent.Text = "Торрент видео через RTSP";
            this.rtsp_torrent.Visible = false;
            this.rtsp_torrent.Click += new System.EventHandler(this.rtsp_torrent_Click);
            // 
            // udp_torrent
            // 
            this.udp_torrent.Name = "udp_torrent";
            this.udp_torrent.Size = new System.Drawing.Size(219, 22);
            this.udp_torrent.Text = "Торрент видео через UDP";
            this.udp_torrent.Visible = false;
            this.udp_torrent.Click += new System.EventHandler(this.udp_torrent_Click);
            // 
            // open_url
            // 
            this.open_url.Name = "open_url";
            this.open_url.Size = new System.Drawing.Size(204, 22);
            this.open_url.Text = "Открыть URL";
            this.open_url.Click += new System.EventHandler(this.open_url_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // settings_menu
            // 
            this.settings_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showmenu,
            this.view_torrent_status_panel,
            this.choose_folder,
            this.clear_cache,
            this.toolStripSeparator3,
            this.address});
            this.settings_menu.Name = "settings_menu";
            this.settings_menu.Size = new System.Drawing.Size(204, 22);
            this.settings_menu.Text = "Настройки";
            this.settings_menu.Click += new System.EventHandler(this.settings_menu_Click);
            // 
            // showmenu
            // 
            this.showmenu.Name = "showmenu";
            this.showmenu.Size = new System.Drawing.Size(320, 22);
            this.showmenu.Text = "Показывать главное меню";
            this.showmenu.Visible = false;
            this.showmenu.Click += new System.EventHandler(this.showMainMenu_Click);
            // 
            // view_torrent_status_panel
            // 
            this.view_torrent_status_panel.Name = "view_torrent_status_panel";
            this.view_torrent_status_panel.Size = new System.Drawing.Size(320, 22);
            this.view_torrent_status_panel.Text = "Показывать панель информации о торренте";
            this.view_torrent_status_panel.Visible = false;
            this.view_torrent_status_panel.Click += new System.EventHandler(this.view_torrent_status_panel_Click);
            // 
            // choose_folder
            // 
            this.choose_folder.Name = "choose_folder";
            this.choose_folder.Size = new System.Drawing.Size(320, 22);
            this.choose_folder.Text = "Выбрать папку для сохранени фильмов";
            this.choose_folder.Visible = false;
            this.choose_folder.Click += new System.EventHandler(this.choose_folder_Click);
            // 
            // clear_cache
            // 
            this.clear_cache.Name = "clear_cache";
            this.clear_cache.Size = new System.Drawing.Size(320, 22);
            this.clear_cache.Text = "Очистить папку кэша";
            this.clear_cache.Visible = false;
            this.clear_cache.Click += new System.EventHandler(this.clear_cache_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(317, 6);
            this.toolStripSeparator3.Visible = false;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(150, 23);
            this.address.Text = "http://192.168.0.103:8080/";
            this.address.Visible = false;
            this.address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.address_KeyDown);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(204, 22);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_menu_top_Click);
            // 
            // seeker_tip
            // 
            this.seeker_tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.seeker_tip.ToolTipTitle = "Перейти к";
            // 
            // volume_tip
            // 
            this.volume_tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.volume_tip.ToolTipTitle = "Громкость";
            // 
            // status_torrent_panel
            // 
            this.status_torrent_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.status_torrent_panel.Controls.Add(this.file_size);
            this.status_torrent_panel.Controls.Add(this.speed);
            this.status_torrent_panel.Controls.Add(this.buffer);
            this.status_torrent_panel.Controls.Add(this.progress);
            this.status_torrent_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status_torrent_panel.Location = new System.Drawing.Point(0, 395);
            this.status_torrent_panel.Name = "status_torrent_panel";
            this.status_torrent_panel.Padding = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.status_torrent_panel.Size = new System.Drawing.Size(777, 25);
            this.status_torrent_panel.TabIndex = 2;
            // 
            // file_size
            // 
            this.file_size.Dock = System.Windows.Forms.DockStyle.Left;
            this.file_size.Location = new System.Drawing.Point(410, 2);
            this.file_size.Name = "file_size";
            this.file_size.Size = new System.Drawing.Size(177, 21);
            this.file_size.TabIndex = 4;
            this.file_size.Text = "Размер файла 0.0 Mb";
            this.file_size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // speed
            // 
            this.speed.Dock = System.Windows.Forms.DockStyle.Left;
            this.speed.Location = new System.Drawing.Point(239, 2);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(171, 21);
            this.speed.TabIndex = 3;
            this.speed.Text = "0.00kB/sec ↓ / 0.00kB/sec ↑";
            this.speed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buffer
            // 
            this.buffer.Dock = System.Windows.Forms.DockStyle.Left;
            this.buffer.Location = new System.Drawing.Point(126, 2);
            this.buffer.Name = "buffer";
            this.buffer.Size = new System.Drawing.Size(113, 21);
            this.buffer.TabIndex = 2;
            this.buffer.Text = "Буферизация 0.0%";
            this.buffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.progress.BarColor = System.Drawing.Color.MediumSlateBlue;
            this.progress.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.progress.Dock = System.Windows.Forms.DockStyle.Left;
            this.progress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.progress.Location = new System.Drawing.Point(6, 2);
            this.progress.Maximum = 100;
            this.progress.Minimum = 0;
            this.progress.Name = "progress";
            this.progress.Progress = null;
            this.progress.ProgressPenColor = System.Drawing.Color.Black;
            this.progress.Size = new System.Drawing.Size(120, 21);
            this.progress.Step = 1;
            this.progress.TabIndex = 0;
            this.progress.Value = 0;
            // 
            // viewport
            // 
            this.viewport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.viewport.ContextMenuStrip = this.player_menu;
            this.viewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewport.Location = new System.Drawing.Point(0, 24);
            this.viewport.Name = "viewport";
            this.viewport.Size = new System.Drawing.Size(777, 371);
            this.viewport.TabIndex = 3;
            this.viewport.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.viewport_MouseDoubleClick);
            this.viewport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewport_MouseDown);
            this.viewport.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewport_MouseMove);
            // 
            // torrent_timer
            // 
            this.torrent_timer.Tick += new System.EventHandler(this.torrent_timer_Tick);
            // 
            // play_list_panel
            // 
            this.play_list_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.play_list_panel.Controls.Add(this.filelist);
            this.play_list_panel.Controls.Add(this.plist_control_panel);
            this.play_list_panel.Controls.Add(this.plist_top_panel);
            this.play_list_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.play_list_panel.Location = new System.Drawing.Point(577, 24);
            this.play_list_panel.Name = "play_list_panel";
            this.play_list_panel.Padding = new System.Windows.Forms.Padding(1);
            this.play_list_panel.Size = new System.Drawing.Size(200, 371);
            this.play_list_panel.TabIndex = 0;
            this.play_list_panel.Visible = false;
            this.play_list_panel.MouseLeave += new System.EventHandler(this.play_list_panel_MouseLeave);
            // 
            // filelist
            // 
            this.filelist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.filelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filelist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.filelist.Font = new System.Drawing.Font("Motiva Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filelist.ForeColor = System.Drawing.Color.AliceBlue;
            this.filelist.FormattingEnabled = true;
            this.filelist.ItemHeight = 30;
            this.filelist.Location = new System.Drawing.Point(1, 25);
            this.filelist.Name = "filelist";
            this.filelist.Size = new System.Drawing.Size(198, 313);
            this.filelist.TabIndex = 2;
            this.filelist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.filelist_MouseDoubleClick);
            // 
            // plist_control_panel
            // 
            this.plist_control_panel.Controls.Add(this.clear_btn_panel);
            this.plist_control_panel.Controls.Add(this.del_btn_panel);
            this.plist_control_panel.Controls.Add(this.add_btn_pan);
            this.plist_control_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plist_control_panel.Location = new System.Drawing.Point(1, 338);
            this.plist_control_panel.Name = "plist_control_panel";
            this.plist_control_panel.Padding = new System.Windows.Forms.Padding(4);
            this.plist_control_panel.Size = new System.Drawing.Size(198, 32);
            this.plist_control_panel.TabIndex = 1;
            // 
            // clear_btn_panel
            // 
            this.clear_btn_panel.Controls.Add(this.button1);
            this.clear_btn_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.clear_btn_panel.Location = new System.Drawing.Point(52, 4);
            this.clear_btn_panel.Name = "clear_btn_panel";
            this.clear_btn_panel.Padding = new System.Windows.Forms.Padding(1);
            this.clear_btn_panel.Size = new System.Drawing.Size(24, 24);
            this.clear_btn_panel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // del_btn_panel
            // 
            this.del_btn_panel.Controls.Add(this.del_btn);
            this.del_btn_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.del_btn_panel.Location = new System.Drawing.Point(28, 4);
            this.del_btn_panel.Name = "del_btn_panel";
            this.del_btn_panel.Padding = new System.Windows.Forms.Padding(1);
            this.del_btn_panel.Size = new System.Drawing.Size(24, 24);
            this.del_btn_panel.TabIndex = 1;
            // 
            // del_btn
            // 
            this.del_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.del_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.Location = new System.Drawing.Point(1, 1);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(22, 22);
            this.del_btn.TabIndex = 2;
            this.del_btn.Text = "-";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // add_btn_pan
            // 
            this.add_btn_pan.Controls.Add(this.add_btn);
            this.add_btn_pan.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_btn_pan.Location = new System.Drawing.Point(4, 4);
            this.add_btn_pan.Name = "add_btn_pan";
            this.add_btn_pan.Padding = new System.Windows.Forms.Padding(1);
            this.add_btn_pan.Size = new System.Drawing.Size(24, 24);
            this.add_btn_pan.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(1, 1);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(22, 22);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // plist_top_panel
            // 
            this.plist_top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.plist_top_panel.Controls.Add(this.pl_caption);
            this.plist_top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.plist_top_panel.Location = new System.Drawing.Point(1, 1);
            this.plist_top_panel.Name = "plist_top_panel";
            this.plist_top_panel.Size = new System.Drawing.Size(198, 24);
            this.plist_top_panel.TabIndex = 0;
            // 
            // pl_caption
            // 
            this.pl_caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_caption.ForeColor = System.Drawing.Color.Gainsboro;
            this.pl_caption.Location = new System.Drawing.Point(0, 0);
            this.pl_caption.Name = "pl_caption";
            this.pl_caption.Size = new System.Drawing.Size(198, 24);
            this.pl_caption.TabIndex = 0;
            this.pl_caption.Text = "Список файлов";
            this.pl_caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tray_icon
            // 
            this.tray_icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tray_icon.Icon = ((System.Drawing.Icon)(resources.GetObject("tray_icon.Icon")));
            this.tray_icon.Text = "uVideo Player";
            this.tray_icon.Visible = true;
            this.tray_icon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tray_icon_MouseClick);
            // 
            // settings_panel
            // 
            this.settings_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.settings_panel.Controls.Add(this.apply_btn);
            this.settings_panel.Controls.Add(this.address_box);
            this.settings_panel.Controls.Add(this.label3);
            this.settings_panel.Controls.Add(this.clear_cache_btn);
            this.settings_panel.Controls.Add(this.label2);
            this.settings_panel.Controls.Add(this.label1);
            this.settings_panel.Controls.Add(this.choose_savedir_btn);
            this.settings_panel.Controls.Add(this.show_torrent_ch);
            this.settings_panel.Controls.Add(this.show_menu_ch);
            this.settings_panel.Controls.Add(this.mListBox1);
            this.settings_panel.Controls.Add(this.pr_top_panel);
            this.settings_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.settings_panel.Location = new System.Drawing.Point(0, 24);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Padding = new System.Windows.Forms.Padding(1);
            this.settings_panel.Size = new System.Drawing.Size(200, 371);
            this.settings_panel.TabIndex = 1;
            this.settings_panel.Visible = false;
            // 
            // apply_btn
            // 
            this.apply_btn.BackColor = System.Drawing.Color.SlateGray;
            this.apply_btn.FlatAppearance.BorderSize = 0;
            this.apply_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.apply_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.apply_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply_btn.Location = new System.Drawing.Point(12, 213);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(163, 23);
            this.apply_btn.TabIndex = 11;
            this.apply_btn.Text = "Применить";
            this.apply_btn.UseVisualStyleBackColor = false;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // address_box
            // 
            this.address_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address_box.Location = new System.Drawing.Point(12, 184);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(163, 23);
            this.address_box.TabIndex = 10;
            this.address_box.Text = "http://192.168.0.103:8080/";
            this.address_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.address_box_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Адрес для трансляции";
            // 
            // clear_cache_btn
            // 
            this.clear_cache_btn.BackColor = System.Drawing.Color.SlateGray;
            this.clear_cache_btn.FlatAppearance.BorderSize = 0;
            this.clear_cache_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.clear_cache_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.clear_cache_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_cache_btn.Location = new System.Drawing.Point(12, 142);
            this.clear_cache_btn.Name = "clear_cache_btn";
            this.clear_cache_btn.Size = new System.Drawing.Size(163, 23);
            this.clear_cache_btn.TabIndex = 8;
            this.clear_cache_btn.Text = "Очистить";
            this.clear_cache_btn.UseVisualStyleBackColor = false;
            this.clear_cache_btn.Click += new System.EventHandler(this.clear_cache_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Очистить папку кэша";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выбрать папку для сохранения фильмов ";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // choose_savedir_btn
            // 
            this.choose_savedir_btn.BackColor = System.Drawing.Color.SlateGray;
            this.choose_savedir_btn.FlatAppearance.BorderSize = 0;
            this.choose_savedir_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.choose_savedir_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.choose_savedir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose_savedir_btn.Location = new System.Drawing.Point(12, 100);
            this.choose_savedir_btn.Name = "choose_savedir_btn";
            this.choose_savedir_btn.Size = new System.Drawing.Size(163, 23);
            this.choose_savedir_btn.TabIndex = 5;
            this.choose_savedir_btn.Text = "Выбрать";
            this.choose_savedir_btn.UseVisualStyleBackColor = false;
            this.choose_savedir_btn.Click += new System.EventHandler(this.choose_savedir_btn_Click);
            // 
            // show_torrent_ch
            // 
            this.show_torrent_ch.AutoSize = true;
            this.show_torrent_ch.Location = new System.Drawing.Point(12, 54);
            this.show_torrent_ch.Name = "show_torrent_ch";
            this.show_torrent_ch.Size = new System.Drawing.Size(177, 17);
            this.show_torrent_ch.TabIndex = 4;
            this.show_torrent_ch.Text = "Показывать панель торрента";
            this.show_torrent_ch.UseVisualStyleBackColor = true;
            this.show_torrent_ch.CheckedChanged += new System.EventHandler(this.show_torrent_ch_CheckedChanged);
            this.show_torrent_ch.Click += new System.EventHandler(this.show_torrent_ch_Click);
            // 
            // show_menu_ch
            // 
            this.show_menu_ch.AutoSize = true;
            this.show_menu_ch.Location = new System.Drawing.Point(12, 31);
            this.show_menu_ch.Name = "show_menu_ch";
            this.show_menu_ch.Size = new System.Drawing.Size(164, 17);
            this.show_menu_ch.TabIndex = 3;
            this.show_menu_ch.Text = "Показывать главное меню";
            this.show_menu_ch.UseVisualStyleBackColor = true;
            this.show_menu_ch.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.show_menu_ch.Click += new System.EventHandler(this.show_menu_ch_Click);
            // 
            // mListBox1
            // 
            this.mListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.mListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mListBox1.Font = new System.Drawing.Font("Motiva Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mListBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.mListBox1.FormattingEnabled = true;
            this.mListBox1.ItemHeight = 30;
            this.mListBox1.Location = new System.Drawing.Point(1, 25);
            this.mListBox1.Name = "mListBox1";
            this.mListBox1.Size = new System.Drawing.Size(198, 345);
            this.mListBox1.TabIndex = 2;
            // 
            // pr_top_panel
            // 
            this.pr_top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pr_top_panel.Controls.Add(this.pr_captions);
            this.pr_top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pr_top_panel.ForeColor = System.Drawing.Color.Gainsboro;
            this.pr_top_panel.Location = new System.Drawing.Point(1, 1);
            this.pr_top_panel.Name = "pr_top_panel";
            this.pr_top_panel.Size = new System.Drawing.Size(198, 24);
            this.pr_top_panel.TabIndex = 0;
            // 
            // pr_captions
            // 
            this.pr_captions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pr_captions.ForeColor = System.Drawing.Color.Gainsboro;
            this.pr_captions.Location = new System.Drawing.Point(0, 0);
            this.pr_captions.Name = "pr_captions";
            this.pr_captions.Size = new System.Drawing.Size(198, 24);
            this.pr_captions.TabIndex = 0;
            this.pr_captions.Text = "Настройки";
            this.pr_captions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compact_view
            // 
            this.compact_view.Name = "compact_view";
            this.compact_view.Size = new System.Drawing.Size(204, 22);
            this.compact_view.Text = "Компактный вид";
            this.compact_view.Click += new System.EventHandler(this.compact_view_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            // 
            // top_on_screen
            // 
            this.top_on_screen.Name = "top_on_screen";
            this.top_on_screen.Size = new System.Drawing.Size(204, 22);
            this.top_on_screen.Text = "Поверх всех окон";
            this.top_on_screen.Click += new System.EventHandler(this.top_on_screen_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 466);
            this.Controls.Add(this.play_list_panel);
            this.Controls.Add(this.settings_panel);
            this.Controls.Add(this.viewport);
            this.Controls.Add(this.status_torrent_panel);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.mainmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainmenu;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uVideo Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_FormClosing);
            this.Load += new System.EventHandler(this.mainform_Load);
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            this.control_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.control_player.ResumeLayout(false);
            this.cast_panel.ResumeLayout(false);
            this.forward_panel.ResumeLayout(false);
            this.next_panel.ResumeLayout(false);
            this.stop_panel.ResumeLayout(false);
            this.pause_panel.ResumeLayout(false);
            this.play_panel.ResumeLayout(false);
            this.volume_panel.ResumeLayout(false);
            this.vol_pan.ResumeLayout(false);
            this.vol_ico_panel.ResumeLayout(false);
            this.player_menu.ResumeLayout(false);
            this.status_torrent_panel.ResumeLayout(false);
            this.play_list_panel.ResumeLayout(false);
            this.plist_control_panel.ResumeLayout(false);
            this.clear_btn_panel.ResumeLayout(false);
            this.del_btn_panel.ResumeLayout(false);
            this.add_btn_pan.ResumeLayout(false);
            this.plist_top_panel.ResumeLayout(false);
            this.settings_panel.ResumeLayout(false);
            this.settings_panel.PerformLayout();
            this.pr_top_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open_menu_top;
        private System.Windows.Forms.ToolStripMenuItem open_torrent_top;
        private System.Windows.Forms.ToolStripMenuItem stream_menu_top;
        private System.Windows.Forms.ToolStripMenuItem exit_menu_top;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel control_player;
        private System.Windows.Forms.Panel stop_panel;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Panel pause_panel;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Panel play_panel;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Panel volume_panel;
        private System.Windows.Forms.Panel panel3;
        private ColorSlider.ColorSlider seeker;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label total_time;
        private System.Windows.Forms.Label current_time;
        private System.Windows.Forms.ContextMenuStrip player_menu;
        private System.Windows.Forms.ToolStripMenuItem playMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem streamMenu;
        private System.Windows.Forms.ToolStripMenuItem playTorrent;
        private System.Windows.Forms.ToolStripMenuItem http_media;
        private System.Windows.Forms.ToolStripMenuItem rtsp_media;
        private System.Windows.Forms.ToolStripMenuItem udp_media;
        private System.Windows.Forms.ToolStripMenuItem streamTorrent;
        private System.Windows.Forms.ToolStripMenuItem http_torrent;
        private System.Windows.Forms.ToolStripMenuItem rtsp_torrent;
        private System.Windows.Forms.ToolStripMenuItem udp_torrent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settings_menu;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem openVideoToolStripMenuItem;
        private System.Windows.Forms.ToolTip seeker_tip;
        private System.Windows.Forms.ToolStripMenuItem showmenu;
        private System.Windows.Forms.ToolTip volume_tip;
        private System.Windows.Forms.ToolStripMenuItem open_url;
        private System.Windows.Forms.ToolStripMenuItem view_torrent_status_panel;
        private System.Windows.Forms.Panel status_torrent_panel;
        private MyProgressBar.MyProgressBar progress;
        private System.Windows.Forms.Panel viewport;
        private System.Windows.Forms.Timer torrent_timer;
        private System.Windows.Forms.Label buffer;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label file_size;
        private System.Windows.Forms.ToolStripMenuItem choose_folder;
        private System.Windows.Forms.ToolStripMenuItem clear_cache;
        private System.Windows.Forms.ToolStripMenuItem playlist_menu;
        private System.Windows.Forms.Panel play_list_panel;
        private System.Windows.Forms.Panel plist_top_panel;
        private System.Windows.Forms.Panel plist_control_panel;
        private System.Windows.Forms.Label pl_caption;
        private System.Windows.Forms.Panel add_btn_pan;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel del_btn_panel;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Panel clear_btn_panel;
        private System.Windows.Forms.Button button1;
        private mListBox filelist;
        private System.Windows.Forms.Panel next_panel;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Panel cast_panel;
        private System.Windows.Forms.Button cast_btn;
        private System.Windows.Forms.Panel forward_panel;
        private System.Windows.Forms.Button forward_btn;
        private System.Windows.Forms.Panel vol_pan;
        private ColorSlider.ColorSlider volume_control;
        private System.Windows.Forms.Panel vol_ico_panel;
        private System.Windows.Forms.Button vol_ico;
        private System.Windows.Forms.NotifyIcon tray_icon;
        private System.Windows.Forms.ToolStripTextBox address;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel settings_panel;
        private mListBox mListBox1;
        private System.Windows.Forms.Panel pr_top_panel;
        private System.Windows.Forms.Label pr_captions;
        private System.Windows.Forms.TextBox address_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear_cache_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choose_savedir_btn;
        private System.Windows.Forms.CheckBox show_torrent_ch;
        private System.Windows.Forms.CheckBox show_menu_ch;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.ToolStripMenuItem compact_view;
        private System.Windows.Forms.ToolStripMenuItem top_on_screen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

