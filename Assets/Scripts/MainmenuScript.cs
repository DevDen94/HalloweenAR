using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainmenuScript : MonoBehaviour
{


    [SerializeField] GameObject MainMenuPanel;
    [SerializeField] GameObject MonsterSelectPanel;
    [SerializeField] GameObject SettingsSelectPanel;
    [SerializeField] Text CoinText;
    
    public bool Sound;
    
    public bool Music;

    public int Coins;






    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        CoinText.text = ""+PlayerPrefs.GetInt("Coins",0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("GamePlay");
    }


    public void MainMenuPanelButton()
    {
        MainMenuPanel.SetActive(true);
        MonsterSelectPanel.SetActive(false);
        SettingsSelectPanel.SetActive(false);
    }


    public void MonsterSelectPanelButton()
    {
        MainMenuPanel.SetActive(false);
        MonsterSelectPanel.SetActive(true);
        SettingsSelectPanel.SetActive(false);
    }

    public void SettingsPanelButton()
    {
        MainMenuPanel.SetActive(false);
        MonsterSelectPanel.SetActive(false);
        SettingsSelectPanel.SetActive(true);

    }

}
