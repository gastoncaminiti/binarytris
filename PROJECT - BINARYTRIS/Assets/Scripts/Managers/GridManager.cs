using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public static int Xgrid = 10;
    public static int Ygrid = 10;

    //public static int Zgrid = 10;

    public static float hOffset = 2f;
    public static float vOffset = 0.5f;
    public static Transform[,] Grid = new Transform[Xgrid, Ygrid];
    static bool isLine(int y)
    {
        for (int x = 0; x < Xgrid; x++)
        {
            if (Grid[x, y] == null)
            {
                return false;
            }
        }
        return true;
    }
    public static void checkPlane()
    {
        for (int y = 0; y < Ygrid; y++)
        {
            if (isLine(y))
            {

                lineDown(y);
            }
        }
    }

    static void lineDown(int y)
    {
        for (int x = 0; x < Xgrid; x++)
        {
            if (Grid[x, y] != null)
            {
                Destroy(Grid[x, y].gameObject);
                Grid[x, y] = null;
            }
        }
    }
}
