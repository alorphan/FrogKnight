using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class ShopController : MonoBehaviour
{
    public Text itemPriceText; 

    public Button buyButton;


    // Start is called before the first frame update
    void Start()
    {
        //moneyAmount = PlayerPrefs.getInt("DewAmount");
    }

    // Update is called once per frame
    void Update()
    {
       // DewAmountText.text = "Dew: " + dewAmount.ToString(); 

        if(dewAmount >= 200)
            buyButton.interactable = true; 
        else
            buyButton.interactable = false; 
    }

    public void buyItem() 
    {
        DewDrops.instance.dew -= 200; 
        buyButton.gameObject.SetActive(false);
    }
}
