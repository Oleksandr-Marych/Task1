namespace Task1;

public class Task3
{
    public static int Max(int[] array)
    {
        int max = array[0];
        for (int i = 1; i<array.Length; i++) {
            if (array[i]>max)
            {
                max = array[i];
            }
        }
        return max;
    }
}