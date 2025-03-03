public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        List<int> less = new List<int>();
        List<int> equal = new List<int>();
        List<int> greater = new List<int>();

        foreach(int num in nums){
            if(num < pivot)
                less.Add(num);
            else if (num == pivot)
                equal.Add(num);
            else
                greater.Add(num);
        }
        List<int> result = new List<int>();
        result.AddRange(less);
        result.AddRange(equal);
        result.AddRange(greater);

        return result.ToArray();
    }
}