namespace BMIApplication.Services
{
    public static class BMIGeneratorService
    {
        public const string UnderWight = "Under Weight";
        public const string NormalWeight = "Normal Weight";
        public const string PreObesity = "Pre-Obesity";
        public const string ObesityClass1 = "Obesity Class 1";
        public const string ObesityClass2 = "Obesity Class 2";

        public static decimal CalculateBMI(decimal height, decimal weight)
        {
            return weight / (height * height);
        }

        public static string CalculateCategory(decimal bmi)
        {
            if (bmi < 18.5m)
                return UnderWight;
            if (bmi < 25)
                return NormalWeight;
            if (bmi < 30)
                return PreObesity;
            if (bmi < 35)
                return ObesityClass1;
            return ObesityClass2;
        }
    }
}
