namespace Reflection_Demo.ViewModel.ClassForReflection
{
    public class Car : BaseViewModel
    {
        private string _color;
        public Car()
        {

        }

        public Car(string color, string mark, int maxSpeed, int weight)
        {
            Color = color;
            Mark = mark;
            MaxSpeed = maxSpeed;
            Weight = weight;
        }

        public string Color { get; }

        public string Mark { get; }

        public int MaxSpeed { get; }

        public int Weight { get; }
    }
}