using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject settings;
    public GameObject Playpage;
    public GameObject homepage;
    public GameObject Rewards_popup;
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
    public void Home_page()
        {
       
            Playpage.SetActive(false);
            homepage.SetActive(true);
            settings.SetActive(false);
        }

    public void Play_page()
        {
       
            homepage.SetActive(false);
            Playpage.SetActive(true);
            settings.SetActive(false);
        Debug.Log("yes");
        }

    public void Setting_page()
    {
        settings.SetActive(true);
        Playpage.SetActive(false);
        homepage.SetActive(false);

    }


    public void Back_button()
    {
        settings.SetActive(false);
        Playpage.SetActive(true);
        homepage.SetActive(false);

    }
    public void Reward_popup()
    {
        Rewards_popup.SetActive(true);
    }



}
