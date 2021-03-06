﻿
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding.Spotify.ApiClient;
using SpotifyWeb.Models;

namespace SpotifyWeb.ViewModels.Builders
{
    public class TrackListModelBuilder
    {
        private readonly RecommendationModel _recommendationModel;
	    private readonly SpotifyApiClient _client;
        public TrackListModelBuilder(RecommendationModel recommendationModel)
        {
            _recommendationModel = recommendationModel;
	        _client = new SpotifyApiClient();
        }

        public async Task<List<TrackViewModel>> BuildAsync()
        {
            
            var response = await _client.SearchArtistsAsync(_recommendationModel.Artist);
            if (response.Artists != null && response.Artists.Total > 0)
            {
                var artist = response.Artists.Items[0];
                var danceability = _recommendationModel.Danceability ? 1.0f : 0.1f;
                var energy = _recommendationModel.Energy * 0.1f;
                var tempo = _recommendationModel.Tempo * 0.1f;
                var trackResponse = await _client.GetRecommendationsAsync(artist.Id, danceability, energy, tempo);
				//taking only these properties for now
                return trackResponse?.Tracks.Select(t => new TrackViewModel {ArtistName = t.Artists?.FirstOrDefault()?.Name, TrackName = t.Name , TrackPreviewUrl = t.PreviewUrl}).ToList();
            }

            return null;
        } 
    }
}