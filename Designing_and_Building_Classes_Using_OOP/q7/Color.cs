public class Color
{
    // Instance variables
    private int red;
    private int green;
    private int blue;
    private int alpha;

    // Constructor that takes red, green, blue, and alpha values
    public Color(int red, int green, int blue, int alpha)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }

    // Constructor that takes red, green, and blue values, with alpha defaulting to 255
    public Color(int red, int green, int blue) : this(red, green, blue, 255)
    {
    }

    // Methods to get and set the red value
    public int GetRed() => red;
    public void SetRed(int value) => red = value;

    // Methods to get and set the green value
    public int GetGreen() => green;
    public void SetGreen(int value) => green = value;

    // Methods to get and set the blue value
    public int GetBlue() => blue;
    public void SetBlue(int value) => blue = value;

    // Methods to get and set the alpha value
    public int GetAlpha() => alpha;
    public void SetAlpha(int value) => alpha = value;

    // Method to get the grayscale value of the color
    public int GetGrayscale()
    {
        return (red + green + blue) / 3;
    }
}


