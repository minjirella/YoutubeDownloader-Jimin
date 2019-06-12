using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using System.IO;
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;

namespace YoutubeDownloader.Controls
{
    public partial class LinkDownloadControl : UserControl
    {
        public LinkDownloadControl()
        {
            InitializeComponent();
        }

        private async void BtnDownload_Click(object sender, EventArgs e)
        {
            /*videoLibrary파일*/
            //using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path" })
            //{
            //    if(fbd.ShowDialog() == DialogResult.OK)
            //    {
            //        var youtube = YouTube.Default;
            //        var video = await youtube.GetVideoAsync(txtLink.Text);
            //        File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());

            //        MessageBox.Show("complete");
            //    }
            //}

            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path" })
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    string url = txtLink.Text;
                    string id = YoutubeClient.ParseVideoId(url);

                    var client = new YoutubeClient();
                    var video = await client.GetVideoAsync(id);

                    // Get metadata for all streams in this video
                    var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(id);

                    // Select one of the streams, e.g. highest quality muxed stream
                    var streamInfo = streamInfoSet.Muxed.WithHighestVideoQuality();

                    // ...or highest bitrate audio stream
                    // var streamInfo = streamInfoSet.Audio.WithHighestBitrate();

                    // ...or highest quality & highest framerate MP4 video stream
                    // var streamInfo = streamInfoSet.Video
                    //    .Where(s => s.Container == Container.Mp4)
                    //    .OrderByDescending(s => s.VideoQuality)
                    //    .ThenByDescending(s => s.Framerate)
                    //    .First();

                    // Get file extension based on stream's container
                    var ext = streamInfo.Container.GetFileExtension();
                    var filePath = fbd.SelectedPath + "\\" + video.Title;

                    // Download stream to file
                    await client.DownloadMediaStreamAsync(streamInfo, $"{filePath}.{ext}").ContinueWith(x =>
                    {
                        MessageBox.Show("complete");
                    });

                    //downloadTask.ContinueWith(x =>
                    //{
                    //    
                    //});
                    
                }
            }
            
        }
    }
}
