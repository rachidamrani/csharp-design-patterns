public class LegacyRectangleAdapter(LegacyRectangle legacyRectangler) : IRectangle
{
    public int GetArea()
    {
        return legacyRectangler.CalculateArea();
    }

    public int GetPerimeter()
    {
        return legacyRectangler.CalculatePerimeter();
    }

    public void Move(long dx, long dy)
    {
        legacyRectangler.Shift(Convert.ToInt32(dx), Convert.ToInt32(dy));
    }
}