using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpeditionButton : MonoBehaviour
{
    public GameObject expeditionPanel;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openExpeditionPanel(GameObject expeditionPanel)
    {
        Debug.Log("hello");
        expeditionPanel.gameObject.SetActive(true);
    }
}
