using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ChatBot.Service
{
    public class ImageScore
    {
        [JsonPropertyName("similar_scores")]
        public string[]? SimilarScores { get; set; }

        [JsonPropertyName("similar_matches")]
        public double[]? SimilarMatches { get; set; }

        public string GetSimilar()
        {
            var index = SimilarMatches!.ToList().IndexOf(SimilarMatches!.Max());
            return SimilarScores![index];
        }

        public List<string>? GetNames()
        {
            return SimilarScores?.Reverse().ToList();
        }
    }
}
