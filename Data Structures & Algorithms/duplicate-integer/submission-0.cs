public class Solution {
    public bool hasDuplicate(int[] nums) {
        var uniqueNums = new HashSet<int>(nums);



        return uniqueNums.Count != nums.Length;
    }
}