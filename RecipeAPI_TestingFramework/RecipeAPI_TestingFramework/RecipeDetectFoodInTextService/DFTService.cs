namespace RecipeAPI_TestingFramework.RecipeDetectFoodInTextService
{
    class DFTService
    {
        FoodInTextCallManager FoodInTextCallManager { get; set; }

        FoodInTextDTO FoodInTextDTO { get; set; }

        private string DetectedFood { get; set; }

        public DFTService(string requestBody)
        {
            DetectedFood = FoodInTextCallManager.GetDetectedFood(requestBody);

            FoodInTextDTO.Desirialize(DetectedFood);
        }
    }
}
