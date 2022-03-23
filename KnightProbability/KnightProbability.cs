using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightProbability
{
    public class KnightProbability
    {
        public static double GetProbability(int n, int k, int r, int c)
        {
            var knightProbability = (double) 1/8;
            var board = new double[n][];
            
            //initialize the board
            for(var i = 0; i<board.Length; i++)
            {
                board[i] = new double[n];
                for(var j = 0; j<board.Length; j++)
                {
                    if (i == r && j == c) board[i][j] = 1;
                    else board[i][j] = 0;
                }
            }

            //iterate through the moves
            for(var ii=0;ii<k; ii++)
            {
                //initialize the new board
                var newBoard = new double[n][];
                for(var jj=0; jj<newBoard.Length; jj++) newBoard[jj] = new double[n];

                for (var cr = 0; cr < n; cr++)
                {                 
                    for (var cc = 0; cc < n; cc++)
                    {
                        var neighboors = GetNeighboors(cr, cc, n);
                        foreach(var neighboor in neighboors) {
                            try
                            {
                                newBoard[neighboor[0]][neighboor[1]] += (double)(board[cr][cc] * knightProbability);
                            } catch
                            {

                            }
                        }
                    }
                }
                board = newBoard;
            }

            double finalProbability = 0;
            foreach(var board_row in board)
            {
                finalProbability += board_row.Sum();
            }

            return finalProbability;
        }

        private static List<List<int>> GetNeighboors(int crow, int ccol, int N)
        {
            var neighboors = new List<List<int>>();
            var directions = new List<List<int>>() {
                new List<int> { -1, -2 },
                new List<int> { -1, 2 },
                new List<int> { 1, -2 },
                new List<int> { 1, 2 },
                new List<int> { 2, 1 },
                new List<int> { -2, -1 },
                new List<int> { -2, 1 },
                new List<int> { 2, -1 },
            };

            foreach(var dir in directions)
            {
                var nr = crow + dir[0];
                var nc = ccol + dir[1];
                if (0 <= nr && nr < N && 0 <= nc && nc < N)
                    neighboors.Add(dir);
            }

            return neighboors;
        }
    }
}
