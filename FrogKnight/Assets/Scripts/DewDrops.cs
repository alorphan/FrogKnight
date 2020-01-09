using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DewDrops : MonoBehaviour
{
    #region singleton
    public static DewDrops instance;
    void Awake() 
    { 
        if(instance != null) 
        {
            Debug.LogWarning("More than one instance of dew"); 
        }
        instance = this; 
    }
    #endregion
    public int dew = 500; 

    public void print()
    {
        Debug.Log(dew);
    }

}
