//метод показує список ресторанів, оцінка яких >= 4.0
public class Function
{
public List<Restaurant> GetRestaurantsWithHighRating()
{
    List<Restaurant> highRatedRestaurants = new List<Restaurant>();
    foreach (Restaurant restaurant in restaurants)
    {
        if (restaurant.Rating >= 4.0)
        {
            highRatedRestaurants.Add(restaurant);
        }
    }
    return highRatedRestaurants;
}
}