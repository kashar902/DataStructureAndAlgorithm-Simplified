namespace SimplifiedDSA.Sorting;
internal class BubbleSortingAlgorithm
{
    private static readonly int[] _array = { 1,4,23,463,24,125,36,54,234,4234,24242,3423,4234,234,24,234,221,1,21,151, };

    /*           Time-Complexity | Space-Complexity
       Best   |     O(n^2)       |     O(1)
       Avg    |     O(n^2)       |     O(1)
       Worst  |     O(n^2)       |     O(1)
    */
    public static int[] BubbleSort()
    {
        int arrayLen = _array.Length - 1;
        for (int i = 0; i < arrayLen; i++)
        {
            for (int j = 0; j < arrayLen; j++)
            {
                if (_array[j] > _array[j + 1])
                {
                    Swap(j, j + 1, _array);
                }
            }
        }
        return _array;
    }

    private static void Swap(int i, int j, int[] nums) =>
        (nums[j], nums[i]) = (nums[i], nums[j]);


    /*           Time-Complexity | Space-Complexity
       Best   |     O(n)         |     O(1)
       Avg    |     O(n^2)       |     O(1)
       Worst  |     O(n^2)       |     O(1)
    */
    public static int[] BubbleSortWithBestApproach()
    {
        int arrLength = _array.Length;
        if (arrLength <= 1) return _array;

        int i = 0;
        bool isSorted = false;
        while (!isSorted)
        {
            isSorted = true;
            for (int j = 0; j < arrLength - 1 - i; j++)
            {
                if (_array[j] > _array[j + 1])
                {
                    Swap(j, j + 1, _array);
                    isSorted = false;
                }
            }
            i++;
        }
        return _array;
    }
}
