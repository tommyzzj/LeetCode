using System;

namespace LeetCode
{
    public class No0189
    {
        public void Rotate(int[] nums, int k)
        {
            #region Solution 1
            // int length = nums.Length;
            // int rotate = k % length;
            // int[] newList = new int[length];
            // for (int i = 0; i < rotate; i++)
            // {
            //     newList[i] = nums[length - rotate + i];
            // }
            //
            // for (int i = 0; i < length - rotate; i++)
            // {
            //     newList[i + rotate] = nums[i];
            // }
            //
            // for (int i = 0; i < length; i++)
            // {
            //     nums[i] = newList[i];
            // }
            #endregion
            
            #region Refined Solution 1
            
            int length = nums.Length;
            int[] newList = new int[length];
            for (int i = 0; i < length; i++)
            {
                newList[(i + k) % length] = nums[i];
            }
            
            Array.Copy(newList,0,nums,0,length);
            
            #endregion
        }
    }
}