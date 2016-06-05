public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       var list = nums.Select((t, i) => new Tuple<int, int>(t, i)).ToList();

            var sortedList = list.OrderBy(x => x.Item1).ToList();

            var leftIndex = 0;
            var rightIndex = sortedList.Count()-1;

            
            for (var i = 0; i < sortedList.Count(); i++)
            {
                if (target == sortedList[leftIndex].Item1 + sortedList[rightIndex].Item1)
                {
                    return new int[] { sortedList[leftIndex].Item2, sortedList[rightIndex].Item2 };
                }
                else if (target > sortedList[leftIndex].Item1 + sortedList[rightIndex].Item1)
                {
                    leftIndex++;
                }
                else
                {
                    rightIndex--;
                }
            }
            return new int[]{-1, -1};
    }
}
