namespace SortManager;

public class BubbleSort : ISortable
{
    public int[] Sort(int[] array)
    {
        if (array == null || array.Length == 0) 
            return array;

        bool isSorted = false;
        int smallerDigit;
        while (isSorted == false)
        {
            bool arrayChangeRequired = false;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    smallerDigit = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = smallerDigit;
                    arrayChangeRequired = true;
                }
            }
            if (arrayChangeRequired == false)
                isSorted = true;
        }
        return array;
    }
}