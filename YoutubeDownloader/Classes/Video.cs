﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader.Classes
{
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Url { get; set; }
        public string Duration { get; set; }
        public Image Thumbnail { get; set; }
    }
}
