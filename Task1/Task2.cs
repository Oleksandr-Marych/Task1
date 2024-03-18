namespace Task1;

public class Task2
{
    public static double Average(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers) {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }
}