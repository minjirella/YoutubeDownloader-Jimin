using Google.Apis.Services;
using Google.Apis.YouTube.v3.Data;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.EnableExceptionHandling();
            //Console.DisplayGoogleSampleHeader("YouTube Data API: Search");

            //SimpleClientCredentials credentials = PromptingClientCredentials.EnsureSimpleClientCredentials();

            //YouTubeService youtube = new YouTubeService(new BaseClientService.Initializer()
            //{
            //    ApiKey = credentials.ApiKey
            //});

            //SearchResource.ListRequest listRequest = youtube.Search.List("snippet");
            //Console.WriteLine("Search term: ");
            //listRequest.Q = Console.ReadLine();
            //listRequest.Order = SearchResource.Order.Relevance;

            //SearchListResponse searchResponse = listRequest.Fetch();

            //List<string> videos = new List<string>();
            //List<string> channels = new List<string>();
            //List<string> playlists = new List<string>();

            //foreach (SearchResult searchResult in searchResponse.Items)
            //{
            //    switch (searchResult.Id.Kind)
            //    {
            //        case "youtube#video":
            //            videos.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
            //            break;

            //        case "youtube#channel":
            //            channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
            //            break;

            //        case "youtube#playlist":
            //            playlists.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
            //            break;
            //    }
            //}

            //Console.WriteLine(String.Format("Videos:\n{0}\n", String.Join("\n", videos.ToArray())));
            //Console.WriteLine(String.Format("Channels:\n{0}\n", String.Join("\n", channels.ToArray())));
            //Console.WriteLine(String.Format("Playlists:\n{0}\n", String.Join("\n", playlists.ToArray())));
            
        }
    }
}
