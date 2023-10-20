using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    [SerializeField] GameObject PausePanel;
    [SerializeField] GameObject GameplayPanel;
    [SerializeField] GameObject GameoverPanel;
    [SerializeField] Text ScoreText;
    [SerializeField] Text TotalScoreText;
    [SerializeField] Text LivesText;
    [SerializeField] GameObject CrossHairKillEffect;
    [SerializeField] GameObject ScreenDamageEffect;
    [SerializeField] GameObject MonsterGenerator;
    public int Score;
    public int TotalScore;
    public int Lives;


    int pre_score,pre_lives;
    

    public int Coins;

    // Start is called before the first frame update
    void Start()
    {
        TotalScore = PlayerPrefs.GetInt("TotalScore", 0);


        Instance = this;
        Time.timeScale = 1;
        StartCoroutine(UIWork());
        pre_score = 0;
        Score = 0;
        pre_lives = Lives;
        Lives = 3;
    }

    
    
    private IEnumerator UIWork()
    {


        while (true)
        {
            
            yield return new WaitForSeconds(0.15f);
            ScoreText.text = "" + Score;
            LivesText.text = "" + Lives;
            
            if(pre_score != Score)
            {
                //Show kill effect
                pre_score = Score;

                CrossHairKillEffect.SetActive(true);
                Invoke("DisableKillEffect", 0.1f);
                
            }

            if(pre_lives != Lives)
            {
                //Show damage taken effect
                pre_lives = Lives;
                ScreenDamageEffect.SetActive(true);
                Invoke("DisableDamageTakenEffect", 0.1f);
            }


            if (Lives <= 0)
            {
                MonsterGenerator.SetActive(false);
                ShowGameOverPanel();
                Destroy(GameObject.FindWithTag("Enemy"));
                
                PlayerPrefs.SetInt("TotalScore",TotalScore + Score);
                TotalScore = TotalScore + Score;
                TotalScoreText.text = "" + TotalScore;


            }




        }
        

        
    }


    private void DisableKillEffect()
    {

        CrossHairKillEffect.SetActive(false);
    }

    private void DisableDamageTakenEffect()
    {

        ScreenDamageEffect.SetActive(false);
    }


    public void PauseButton()
    {
        Time.timeScale = 0;

        PausePanel.SetActive(true);
        GameplayPanel.SetActive(false);
        



    }


    public void ResumeButton()
    {
        Time.timeScale = 1;

        PausePanel.SetActive(false);
        GameplayPanel.SetActive(true);
        

    }


    public void RestartButton()
    {
        SceneManager.LoadScene("GamePlay");

    }


    public void SettingsButton()
    {
        PausePanel.SetActive(false);
        GameplayPanel.SetActive(false);
       


    }


    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");

    }

    public void ShowGameOverPanel()
    {
        PausePanel.SetActive(false);
        GameplayPanel.SetActive(false);
        GameoverPanel.SetActive(true);

    }

}
