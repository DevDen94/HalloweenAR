using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuScript : MonoBehaviour
{


    [SerializeField] GameObject MainMenuPanel;
    [SerializeField] GameObject MonsterSelectPanel;
    [SerializeField] GameObject SettingsSelectPanel;
    
    public bool Sound;
    
    public bool Music;

    public int Coins;





    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
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

    }


    public void MonsterSelectPanelButton()
    {

    }

    public void SettingsPanelButton()
    {


    }

}
