using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
  /*  void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
*/ 
//function for going to the hub scene 
    public void goToScene()
    { 
        SceneManager.LoadScene("hub"); 
    }
        
}
