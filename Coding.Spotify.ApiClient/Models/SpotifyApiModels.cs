﻿using System.Collections.Generic;
using Newtonsoft.Json;

/* Hint: Use http://jsonutils.com/ to generate models from JSON responses from the API. */

namespace Coding.Spotify.ApiClient.Models
{
    public class SearchArtistResponse
    {
        [JsonProperty("artists")]
        public SearchArtistCollection Artists { get; set; }
    }

	public class TrackListResponse
	{
		[JsonProperty("tracks")]
		public IList<Track> Tracks { get; set; }
	}


	public class SearchArtistCollection
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("items")]
        public IList<Artist> Items { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public object Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class Artist
    {
        [JsonProperty("external_urls")]
        public ExternalUrls ExternalUrls { get; set; }

        [JsonProperty("genres")]
        public IList<object> Genres { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("images")]
        public IList<Image> Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ExternalUrls
    {
        [JsonProperty("spotify")]
        public string Spotify { get; set; }
    }

    public class Image
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

	public class Track
	{
		//Some properties from tracks
		[JsonProperty("artists")]
		public IList<Artist> Artists { get; set; }

		[JsonProperty("duration_ms")]
		public int DurationMs { get; set; }

		[JsonProperty("external_urls")]
		public ExternalUrls ExternalUrls { get; set; }

		[JsonProperty("href")]
		public string Href { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("is_playable")]
		public bool IsPlayable { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("popularity")]
		public int Popularity { get; set; }

		[JsonProperty("preview_url")]
		public string PreviewUrl { get; set; }

		[JsonProperty("track_number")]
		public int TrackNumber { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("uri")]
		public string Uri { get; set; }
	}

}
