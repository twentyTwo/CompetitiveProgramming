public class Solution {
    public bool IsValidSudoku(char[,] board)
        {
            var nums = new int[10];

            /*For all the rows, check whether same number exists in a row */
            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    if (board[i, j] != '.')
                    {
                        var num = board[i, j];
                        if (num != '.')
                        {
                            var index = int.Parse(num.ToString());
                            if (nums[index] != 0)
                            {
                                return false;
                            }
                            nums[index] = 1;
                        }
                    }
                }
                // Re-initialize the number checker array nums to 0
                for (var k = 0; k < 10; k++)
                {
                    nums[k] = 0;
                }
            }
            
            /*For all the columns, check whether same number exists in a column */
            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    if (board[j, i] != '.')
                    {
                        var num = board[j, i];
                        if (num != '.')
                        {
                            var index = int.Parse(num.ToString());
                            if (nums[index] != 0)
                            {
                                return false;
                            }
                            nums[index] = 1;
                        }
                    }
                }
                // Re-initialize the number checker array nums to 0
                for (var k = 0; k < 10; k++)
                {
                    nums[k] = 0;
                }
            }

            /* Check whether the 9 blocks (3*3 block) contains same number */
            for (var R = 0; R < 7; R = R + 3)
            {
                for (var C = 0; C < 7; C = C + 3)
                {
                    for (var i = R; i <= 2 + R; i++)
                    {
                        for (var j = C; j <= 2 + C; j++)
                        {
                            var num = board[j, i];
                            if (num != '.')
                            {
                                var index = int.Parse(num.ToString());
                                if (nums[index] != 0)
                                {
                                    return false;
                                }
                                nums[index] = 1;
                            }
                        }
                    }
                    // Re-initialize the number checker array nums to 0
                    for (var k = 0; k < 10; k++)
                    {
                        nums[k] = 0;
                    }
                }
                // Re-initialize the number checker array nums to 0
                for (var k = 0; k < 10; k++)
                {
                    nums[k] = 0;
                }
            }
            return true;
        }
}
