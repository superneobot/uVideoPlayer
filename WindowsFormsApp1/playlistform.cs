using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace uPlayer
{
    public partial class playlistform : Form
    {
        public List<MediaFile> plistfiles { get; set; }
        public playlistform()
        {
            InitializeComponent();
            plistfiles = new List<MediaFile>();
        }

        private void playlistform_Load(object sender, EventArgs e)
        {
            foreach (var item in plistfiles)
            {
                list_files.Items.Add(item.Name);
            }
        }

        private void list_files_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_files_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (list_files.SelectedIndices.Count >= 0)
            {
                var index = list_files.Items.IndexOf(list_files.SelectedItems[0]);
                mainform frm = new mainform();
                string[] param = new string[]
                   {
                     //
                   };
                var file = plistfiles[index].Path;
                frm.PlayMediaFileFromPlayList(Type.Media, PlayingType.Watching, StreamType.None, file);
                this.Close();
            }
        }
    }
}
