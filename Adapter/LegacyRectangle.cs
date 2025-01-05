public class LegacyRectangle(int left, int top, int right, int bottom)
{
    public int CalculateArea()
    {
        return (bottom - top) * (right - left);
    }

    public int CalculatePerimeter()
    {
        int height = bottom - top;
        int width = right - left;

        return (height + width) * 2;
    }

    public void Shift(int h, int v)
    {
        top += v;
        bottom += v;
        right += h;
        left += h;
    }
}