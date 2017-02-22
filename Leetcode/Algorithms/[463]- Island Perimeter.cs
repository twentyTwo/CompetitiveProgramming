public class Solution {
private static int[,] newGrid;

        private int Sum = 0;

        public int IslandPerimeter(int[,] grid)
        {
            int r = grid.GetLength(0);
            int c = grid.GetLength(1);

            newGrid = new int[r + 2, c + 2];
            newGrid.Initialize();

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    newGrid[i + 1, j + 1] = grid[i, j];
                }
            }

            for (int i = 1; i < r + 1 ; i++)
            {
                for (int j = 1; j < c + 1; j++)
                {
                    if (newGrid[i, j] == 1)
                    {
                        return ExploreIsland(i, j);                      
                    }
                }
            }

            return 0;
        }

        public int ExploreIsland(int i, int j)
        {
            if (newGrid[i - 1, j] == 0) {
                Sum += 1;
            }

            if (newGrid[i + 1, j] == 0)
            {
                Sum += 1;
            }

            if (newGrid[i, j - 1] == 0)
            {
                Sum += 1;
            }

            if (newGrid[i, j + 1] == 0)
            {
                Sum += 1;
            }

            newGrid[i, j]+=1 ;
            // Recursive Call
            if (newGrid[i - 1, j] == 1)
            {
       
                ExploreIsland(i - 1, j);
                
            }

            if (newGrid[i + 1, j] == 1)
            {

                ExploreIsland(i + 1, j);
               
            }

            if (newGrid[i, j - 1] == 1)
            {

                ExploreIsland(i, j - 1);
                
            }

            if (newGrid[i, j + 1] == 1)
            {
                ExploreIsland(i, j + 1);
               
            }

            return Sum;
        }
}
