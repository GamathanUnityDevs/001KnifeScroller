using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Applicationexit : MonoBehaviour
{
    public GameObject applicationQuit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void Yesquit()
    {
        
        Application.Quit();
        Debug.Log("Quit the application");
        
    }
    public void NoQuit()
    {
        applicationQuit.SetActive(false);
    }
}
