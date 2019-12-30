using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DewDrops : MonoBehaviour
{
    public int dew = 500; 

    public static DewDrops instance; 
    public void print()
    {
        Debug.Log(dew);
    }
}
