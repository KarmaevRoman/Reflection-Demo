namespace Reflection_Demo.ViewModel.ClassForReflection
{
    internal class Table
    {
        public Table(string color, string material, int width, int height)
        {
            Color = color;
            Material = material;
            Width = width;
            this.height = height;
        }

        public string Color { get; }

        public string Material { get; }

        public int Width { get; }

        public int height { get; }
    }
}