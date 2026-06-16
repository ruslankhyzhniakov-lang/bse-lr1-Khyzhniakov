    public class Restaurant
    {
        public string Name;
        public string CuisineType;
        public double Rating;
    }

    public class RecommendationModule
    {
        public double CalculateRecommendationScore(double averageRating, bool likedCuisine, decimal price, int reviewCount)
        {
            double score = averageRating * 2;
            if (likedCuisine)
            {
                score = score + 3;
            }
            else
            {
                score = score + 1;
            }

            if (price > 20)
            {
                score = score - 1;
            }
            if (price < 10)
            {
                score = score + 1;
            }

            if (reviewCount == 0)
            {
                score = score - 2;
            }

            return score;
        }






    }


