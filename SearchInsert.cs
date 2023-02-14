public class Solution {
    public int SearchInsert(int[] nums, int target) {
        //define length of index based on number of integers contained minus 1 to account for [0]
        int indexNum = (nums.Count() - 1);
        //create a variable to track the current integer being compared, and the index
        int current = nums[0];
        int index = 0;
        //in case target is the first integer
        if(current == target) 
        return 0;
        //if target # is greater than any # in the array
        if(target > nums[indexNum]) {
        return ++indexNum;
        } else
        //using for loop to check each integer
        for(index = 0; index < indexNum; index++) {
            current = nums[index];
            if(current >= target) {
                break;
            }
        } 
    return index;
    }
}