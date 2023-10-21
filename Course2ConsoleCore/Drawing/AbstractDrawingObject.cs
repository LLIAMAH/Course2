namespace Course2ConsoleCore.Drawing
{
    public abstract class AbstractDrawingObject
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        //public FigureType FigureType { get; private set; }


        //public void SetCoordinates(int x, int y, FigureType type)
        public void SetCoordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
            //this.FigureType = type; 
        }

        public abstract void Draw();

        //public void Draw()
        //{
        //    switch (this.FigureType)
        //    {
        //        case FigureType.Circle:
        //            DrawCircle(X, Y);
        //        break;
        //        case FigureType.Diamond:
        //            DrawDiamond(X, Y);
        //            break;
        //        case FigureType.Square:
        //            DrawSquare(X, Y);
        //            break;
        //        case FigureType.Triangle:
        //            DrawTriangle(X, Y);
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //private void DrawCircle(int x, int y)
        //{
        //    throw new NotImplementedException();
        //}
        //private void DrawDiamond(int x, int y)
        //{
        //    throw new NotImplementedException();
        //}
        //private void DrawSquare(int x, int y)
        //{
        //    throw new NotImplementedException();
        //}
        //private void DrawTriangle(int x, int y)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
