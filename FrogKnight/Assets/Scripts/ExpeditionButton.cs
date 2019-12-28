using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExpeditionButton : MonoBehaviour
{


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void openExpedition()
    {
        SceneManager.LoadScene("expeditionstart");
    }

    public void openShop1()
    {
        SceneManager.LoadScene("shop1");
    }

    public void openInventory()
    {
        SceneManager.LoadScene("inventory");
    }

    public void openOptions()
    {
        SceneManager.LoadScene("options");
    }
}
