using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubController : MonoBehaviour
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

    public void closeExpeditionPanel(GameObject expeditionPanel)
    {
        expeditionPanel.gameObject.SetActive(false);
    }
}
