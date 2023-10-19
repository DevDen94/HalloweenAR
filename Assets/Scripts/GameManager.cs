using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    [SerializeField]
    Text KillsText;
    [SerializeField]
    Text DeathText;
    [SerializeField]
    GameObject CH;

    public int Kills;
    public int Deaths;
    int pre_val;

    public int Coins;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        StartCoroutine(UIWork());
        pre_val = 0;
        Kills = 0;
        Deaths = 0;
    }

    
    
    private IEnumerator UIWork()
    {


        while (true)
        {
            
            yield return new WaitForSeconds(0.15f);
            KillsText.text = Kills + "";
            DeathText.text = Deaths + "";
            
            if(pre_val != Kills)
            {
                //Show kill effect
                pre_val = Kills;

                CH.SetActive(true);
                Invoke("DisableKillEffect", 0.1f);
                
            }
        }
        

        
    }


    private void DisableKillEffect()
    {

        CH.SetActive(false);
    }


    public void ResumeButton()
    {


    }


    public void RestartButton()
    {


    }


    public void SettingsPanel()
    {



    }


    public void MenuButton()
    {


    }


}
