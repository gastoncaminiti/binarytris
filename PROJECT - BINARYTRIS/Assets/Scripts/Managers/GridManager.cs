using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public static int Xgrid = 10;
    public static int Ygrid = 10;

    //public static int Zgrid = 10;

    public static int Zoffset = 2;
	
    public static Transform[,] Grid = new Transform[Xgrid,Ygrid];
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
