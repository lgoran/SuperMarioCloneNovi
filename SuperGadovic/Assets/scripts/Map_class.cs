using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_class
{
    public static int[][] polje;
    public static bool[] prijedeni_leveli;
    public static int povratak_u_scenu = 0;
    public static int currPos = 0;
    public static int pom = -1;
    static Map_class()
    {
        polje = new int[100][];
        for (int i = 0; i < 100; i++)
            polje[i] = new int[] { -1, -1, -1, -1 };
        //INICIJALIZACIJA gore-0, desno-1, dolje-2, lijevo-3
        polje[0][2] = 1;
        polje[1][0] = 0; polje[1][1] = 2; polje[1][3] = 3;
        polje[2][3] = 1;
        /*polje[3][3]=4;*/
        polje[3][1] = 1;
        polje[4][0] = 5; polje[4][1] = 3;
        /*polje[5][0] = 6;*/
        polje[5][2] = 4;
        polje[6][1] = 7; polje[6][2] = 5;
        polje[7][0] = 9; polje[7][1] = 8; polje[7][3] = 6;
        polje[8][3] = 7;
        polje[9][2] = 7; polje[9][3] = 10;
        polje[10][1] = 9;   //polje[10][3] = 11;
        polje[11][0] = 12; polje[11][1] = 10;
        polje[12][1] = 13; polje[12][2] = 11;
        /*polje[13][1] = 14;*/
        polje[13][3] = 12;
        polje[14][2] = 15; polje[14][3] = 13;
        polje[15][0] = 14; polje[15][1] = 16;
        polje[16][2] = 17; polje[16][3] = 15;
        polje[17][0] = 16;

        prijedeni_leveli = new bool[] { false, false, false, false };
    }
    public static void PrijedenLevel(int broj_levela)
    {
        prijedeni_leveli[broj_levela - 1] = true;
        if (broj_levela == 1)
            polje[3][3] = 4;
        else if (broj_levela == 2)
            polje[5][0] = 6;
        else if (broj_levela == 3)
            polje[10][3] = 11;
        else if (broj_levela == 4)
            polje[13][1] = 14;

    }
}
