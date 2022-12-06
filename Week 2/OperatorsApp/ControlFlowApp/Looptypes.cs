using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowApp
{
    public static class Looptypes
    {
        internal static int HighestDoWhileLoop(List<int> nums)
        {
            throw new NotImplementedException();
        }

        internal static int HighestForEachLoop(List<int> nums)
        {
            int highest = nums[0];
            foreach (int i in nums)
            {
                if (i > highest)
                {
                    highest = i;
                }
            } return highest;

        }

        internal static int HighestForLoop(List<int> nums)
        {
            int highest = nums[0];
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
            }

            return highest;

            
        }

        internal static string HighestWhileLoop(List<int> nums)
        {
            
        }
    }
}