namespace Reflection_Demo.ViewModel.ClassForReflection
{
    internal class Car
    {
        public Car(string color, string mark, int masSpeed, int weight)
        {
            Color = color;
            Mark = mark;
            MasSpeed = masSpeed;
            Weight = weight;
        }

        public string Color { get; }

        public string Mark { get; }

        public int MasSpeed { get; }

        public int Weight { get; }
    }
}