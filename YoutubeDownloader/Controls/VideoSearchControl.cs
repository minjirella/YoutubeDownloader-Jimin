using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using YoutubeDownloader.Classes;
using YoutubeSearch;

namespace YoutubeDownloader.Controls
{
    public partial class VideoSearchControl : UserControl
    {
        public VideoSearchControl()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            VideoSearch items = new VideoSearch();
            List<Video> list = new List<Video>();

            foreach (var item in items.SearchQuery(txtTitle.Text, 1))
            {
                Video video = new Video();
                video.Title = item.Title;
                video.Author = item.Author;
                video.Url = item.Url;
                byte[] imageBytes = new WebClient().DownloadData(item.Thumbnail);

                using(MemoryStream ms = new MemoryStream(imageBytes))
                {
                    video.Thumbnail = Image.FromStream(ms);
                }
                list.Add(video);
            }
            bdsVideo.DataSource = list;
        }

        internal void ClearText()
        {
            txtTitle.Text = "";
            bdsVideo.DataSource = null;
        }

        private void DgvVideo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Video video = dgvVideo.CurrentRow.DataBoundItem as Video;
            System.Diagnostics.Process.Start(video.Url);
            Clipboard.SetText(video.Url);
        }
    }
}
