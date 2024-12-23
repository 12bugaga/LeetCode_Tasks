public class Solution {
    public int[] SortArray(int[] nums) {
        //QuickSort(nums, 0, nums.Length - 1);
        //return nums;

        return MergeSort(nums);
    }

    public int[] MergeSort(int[] arr)
    {
        if(arr.Length <= 1)
            return arr;

        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        for(int i = 0; i < left.Length; i++)
            left[i] = arr[i];

        for(int i = 0; i < right.Length; i++)
            right[i] = arr[i + mid];

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(arr, left, right);
    }

    public int[] Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0;
        int j = 0;
        int k = 0;

        while(i < left.Length && j < right.Length)
        {
            if(left[i] < right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }

            k++;
        }

        while(i < left.Length)
        {
            arr[k] = left[i];
            i++;
            k++;
        }

        while(j < right.Length)
        {
            arr[k] = right[j];
            j++;
            k++;
        }

        return arr;
    }

    
    public void QuickSort(int[] arr, int left, int right)
    {
        if(left >= right)
            return;

        int pivot = FindPivot(arr, left, right);
        QuickSort(arr, left, pivot - 1);
        QuickSort(arr, pivot + 1, right);
    }

    public int FindPivot(int[] arr, int left, int right)
    {
        int pivot = left;

        for(int i = left; i < right; i++)
        {
            if(arr[i] < arr[right])
            {
                Swap(ref arr[i], ref arr[pivot]);
                pivot++;
            }
        }

        Swap(ref arr[pivot], ref arr[right]);

        return pivot;
    }

    public void Swap (ref int left, ref int right)
    {
        var t = left;
        left = right;
        right = t;
    }
    
}