namespace MauiApp1
{

    public class MyFirstDrawing : IDrawable
    {
        // Bild laden
        // View Frustum

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 6;
            canvas.DrawLine(10, 10, 90, 100);
        }
    }
}
