using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance; 

    void Awake() 
    { 
        if(instance != null) 
        {
            Debug.LogWarning("More than one instance of inventory"); 
        }
        instance = this; 
    }
    #endregion
    public delegate void OnItemChanged(); 
    public OnItemChanged onItemChangedCallback; 

   public List<Item> items; 

   public void Add(Item item)
   {
       items.Add(item); 

       if(onItemChangedCallback != null)
            onItemChangedCallback.Invoke(); //update UI 
   }

}
