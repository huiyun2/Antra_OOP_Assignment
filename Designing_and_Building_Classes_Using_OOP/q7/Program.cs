using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a few Color instances
        Color redColor = new Color(255, 0, 0);
        Color greenColor = new Color(0, 255, 0);
        Color blueColor = new Color(0, 0, 255, 128);

        // Create a few Ball instances
        Ball ball1 = new Ball(10, redColor);
        Ball ball2 = new Ball(15, greenColor);
        Ball ball3 = new Ball(20, blueColor);

        // Throw the balls around a few times
        ball1.Throw();
        ball1.Throw();
        ball2.Throw();
        ball3.Throw();
        ball3.Throw();
        ball3.Throw();

        // Pop a few balls
        ball1.Pop();
        ball3.Pop();

        // Try throwing the popped balls
        ball1.Throw();
        ball3.Throw();

    
        Console.WriteLine($"Ball 1 has been thrown {ball1.GetThrowCount()} times.");
        Console.WriteLine($"Ball 2 has been thrown {ball2.GetThrowCount()} times.");
        Console.WriteLine($"Ball 3 has been thrown {ball3.GetThrowCount()} times.");
    }
}



