using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F1ligapontszamito
{
    static class Dictionaries 
    {
        
        // Mivel ez nem módosítható kívülről, ezért lehet statuc class, bár nem szokták javasolni, mert nehezen unit tesztelhető. Itt most ezt elnézzük.

        
        public static Dictionary<int, int> QualTeamDic { get; set; }

        public static Dictionary<int, int> QualDriverDic { get; set; }

        public static Dictionary<int, int> RaceDriverDic { get; set; }

        public static Dictionary<int, int> RaceTeamDic { get; set; }

        //Static constructurtor.
        static Dictionaries()
        {
            QualTeamDic = new Dictionary<int, int>()
             {
                            {1, 15}, 
                            {2, 10},
                            {3, 8},
                            {4, 7},
                            {5, 6},             
                            {6, 5},
                            {7, 4},
                            {8, 3},
                            {9, 2},
                            {10, 1}
                          
              };

            QualDriverDic = new Dictionary<int, int>()
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
            RaceDriverDic = new Dictionary<int, int>() 
            {
                {1, 100},
                {2, 80},
                {3, 70},
                {4, 60},
                {5, 50},
                {6, 40},
                {7, 30},
                {8, 20},
                {9, 25},
                {10, 15},
                {11, 13},
                {12, 10},
                {13, 8},
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
            RaceTeamDic = new Dictionary<int, int>() 
            {
               {1, 45},
               {2, 35},
               {3, 30},
               {4, 26},
               {5, 24},
               {6, 22},
               {7, 20},
               {8, 18},
               {9, 16},
               {10, 14},
               {11, 12},
               {12, 10},
               {13, 8},
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
        }
    }
}
