namespace BMIApplication.Services
{
    public static class BMIGeneratorService
    {
        public static decimal CalculateBMI(decimal height, decimal weight)
        {
            return weight / (height * height);
        }
    }
}
