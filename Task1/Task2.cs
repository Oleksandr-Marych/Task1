namespace Task1;

public class Task2
{
    public static double Average(int[] list)
    {
        int sum = 0;
        foreach (int num in list) {
            sum += num;
        }

        return (double)sum / list.Length;
    }
}