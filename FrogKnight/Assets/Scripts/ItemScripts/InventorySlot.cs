using UnityEngine;
using UnityEngine.UI; 


public class InventorySlot : MonoBehaviour
{
    public Image icon; 
   Item item; // item in the slot 

    
   public void AddItem(Item newItem) 
   {
       item = newItem; 

       icon.sprite = item.icon; 
       icon.enabled = true; 
   }

   public void SelectItem()
   {
       if (item != null)
       {
           
       }
   }
}
