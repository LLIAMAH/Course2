using System.Drawing;

namespace Course2ConsoleCore.Drawing
{
    public class CircleColored: Circle
    {
        public Color Color { get; set; }

        public void SetColor(Color color)
        {
            this.Color = color;
        }

        public override void Draw()
        {
            Console.WriteLine("Здесь долждно быть рисование круга");
            Console.WriteLine("Здесь долждно быть добавление цвета в круг");
        }
    }
}
