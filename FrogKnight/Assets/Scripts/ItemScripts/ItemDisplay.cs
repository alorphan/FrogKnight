using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ItemDisplay : MonoBehaviour
{

    public Item item; 
    // Start is called before the first frame update
    //public Text nameText; 
   // public Text flavorText; 
    public Text priceText; 
    public Image iconImage; 

    void Start()
    {
        //Debug.Log(item.name);
        //nameText.Text = item.name; 
        //flavorText.Text = item.flavor; 
        priceText.text = item.price.ToString(); 
        iconImage.sprite = item.icon; 
        

        item.Print(); 
    }

   
}
