using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class ShopController : MonoBehaviour
{
    int dewAmount = 500;

    public Text dewAmountText;
    public Text itemPriceText; 

    public Button buyButton;

    public Text DewAmountText { get => dewAmountText; set => dewAmountText = value; }

    // Start is called before the first frame update
    void Start()
    {
        //moneyAmount = PlayerPrefs.getInt("DewAmount");
    }

    // Update is called once per frame
    void Update()
    {
        DewAmountText.text = "Dew: " + dewAmount.ToString(); 

        if(dewAmount >= 200)
            buyButton.interactable = true; 
        else
            buyButton.interactable = false; 
    }

    public void buyItem() 
    {
        dewAmount -= 200; 
        buyButton.gameObject.SetActive(false);
    }
}
