namespace Reflection_Demo.ViewModel.ClassForReflection
{
    public class Table
    {
        public Table()
        {

        }
        public Table(string color, string material, int width, int height)
        {
            Color = color;
            Material = material;
            Width = width;
            this.Height = height;
        }

        public string Color { get; }

        public string Material { get; }

        public int Width { get; }

        public int Height { get; }
    }
}