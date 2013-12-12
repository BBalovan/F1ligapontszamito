using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F1ligapontszamito
{
    static class Dictionaries //Lehet, hogy nem is osztályt kéne használnom?
    {
        // Itt nem inicializálunk változót. Ezeknek a konstruktorban a helyük, vagy metódusban, esetleg readonly property get ágában.
        // Mivel ez nem módosítható kívülről, ezért lehet statuc class, bár nem szokták javasolni, mert nehezen unit tesztelhető. Itt most ezt elnézzük.

        //Ennek adhatnál beszédesebb nevet is. Fél év múlva azt se fogod tudni miért hoztad létre.
        public static Dictionary<int, int> Dic2 { get; set; }

        public static Dictionary<int, int> Dic1 { get; set; }

        //Static constructurtor.
        static Dictionaries()
        {
            Dic2 = new Dictionary<int, int>()
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

            Dic1 = new Dictionary<int, int>()
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
        }
    }
}
