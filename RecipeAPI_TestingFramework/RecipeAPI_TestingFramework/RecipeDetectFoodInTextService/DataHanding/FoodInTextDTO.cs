using Newtonsoft.Json;

namespace RecipeAPI_TestingFramework
{
    class FoodInTextDTO
    {
        FoodInTextRoot FoodInTextRoot { get; set; }
        public void Desirialize(string detectedFood)
        {
            FoodInTextRoot = JsonConvert.DeserializeObject<FoodInTextRoot>(detectedFood);
        }
    }
}