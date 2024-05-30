public class Ball
{
    // Instance variables
    private int size;
    private Color color;
    private int throwCount;

    // Constructor that takes size and color
    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.throwCount = 0;
    }

    // Method to "pop" the ball, setting its size to 0
    public void Pop()
    {
        size = 0;
    }

    // Method to throw the ball, incrementing the throw count if the ball is not popped
    public void Throw()
    {
        if (size > 0)
        {
            throwCount++;
        }
    }

    // Method to get the number of times the ball has been thrown
    public int GetThrowCount() => throwCount;
}


