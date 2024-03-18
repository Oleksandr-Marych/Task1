namespace Task1;

public class Task2
{
    public static double Average(int[] array)
    {
        int sum = 0;
        foreach (int num in array) {
            sum += num;
        }

        return (double)sum / array.Length;
    }
}