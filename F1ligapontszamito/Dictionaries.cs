using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F1ligapontszamito
{
    class Dictionaries //Lehet, hogy nem is osztályt kéne használnom?
    {
        Dictionary<int, int> dic2 = new Dictionary<int, int>()
             {
                            {1, 15}, 
                            {2, 10},
                            {3, 8},
                            {4, 7},
                            {5, 6},             //ezt hívnám be, ha tudnám
                            {6, 5},
                            {7, 4},
                            {8, 3},
                            {9, 2},
                            {10, 1}
                          
              };
        public System.Collections.Generic.Dictionary<int, int> GetDic2()
        {
            return dic2;
        }

        Dictionary<int, int> dic1 = new Dictionary<int, int>()
                {
                     {1, 30},
                     {2, 20},
                     {3, 18},
                     {4, 16},
                     {5, 15},
                     {6, 14},
                     {7, 13},
                     {8, 12},
                     {9, 11},
                     {10, 10},
                     {11, 9},
                     {12, 8},
                     {13, 7},
                     {14, 6},
                     {15, 5},
                     {16, 4},
                     {17, 4},
                     {18, 3},
                     {19, 3},
                     {20, 2},
                     {21, 2},
                     {22, 1},
                     {23, 1},
                     {24, 0}
    
                 };
        public System.Collections.Generic.Dictionary<int, int> GetDic1()
        {
            return dic1;
        }
    }
}
