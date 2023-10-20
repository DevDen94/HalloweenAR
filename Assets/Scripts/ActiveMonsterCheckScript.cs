using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveMonsterCheckScript : MonoBehaviour
{
    [SerializeField] Button[] MonstersButton;
    public int TotalCandies;
    [SerializeField] GameObject[] SelectionImage;
    public Text TotalCandiesText;
    int MonsterSelect;

    int BatCheck;
    int GhostCheck;
    int WitchCheck;
    int MummyCheck;
    int DracsCheck;


    // Start is called before the first frame update
    void Start()
    {
        TotalCandies = PlayerPrefs.GetInt("TotalScore",0);
        MonsterSelect = PlayerPrefs.GetInt("MonsterSelect", 0);

        BatCheck   = PlayerPrefs.GetInt("BatCheck", 0);
        GhostCheck = PlayerPrefs.GetInt("GhostCheck", 0);
        WitchCheck = PlayerPrefs.GetInt("WitchCheck", 0);
        MummyCheck = PlayerPrefs.GetInt("MummyCheck", 0);
        DracsCheck = PlayerPrefs.GetInt("DracsCheck", 0);


        DisableAllSelectionImagesExceptSelected(MonsterSelect);
    }

    // Update is called once per frame
    void Update()
    {
        TotalCandiesText.text = "" + TotalCandies;

        if (Input.GetKeyDown(KeyCode.Space)) //give hundred candies
        {
            PlayerPrefs.SetInt("TotalScore", 100);
            print("Candies 100");
        }

        if (Input.GetKeyDown(KeyCode.X)) //set 0 candies
        {
            PlayerPrefs.SetInt("TotalScore", 0);
            print("Candies 0");
        }

    }


    public void PurchasePumpkin()
    {
      
         DisableAllSelectionImagesExceptSelected(0);
         PlayerPrefs.SetInt("TotalScore", TotalCandies);
        
    }

    public void PurchaseBats()
    {
        if (BatCheck == 1)
        {
            DisableAllSelectionImagesExceptSelected(1);
        }
        else if (TotalCandies >= 50)
        {
            DisableAllSelectionImagesExceptSelected(1);
            TotalCandies = TotalCandies - 50;
            PlayerPrefs.SetInt("TotalScore", TotalCandies);
            PlayerPrefs.SetInt("BatCheck", 1);
        }

    }


    public void PurchaseGhost()
    {
        if (GhostCheck == 1)
        {
            DisableAllSelectionImagesExceptSelected(2);
        }
        else if(TotalCandies >= 70)
        {
            DisableAllSelectionImagesExceptSelected(2);
            TotalCandies = TotalCandies - 70;
            PlayerPrefs.SetInt("TotalScore", TotalCandies);
            PlayerPrefs.SetInt("GhostCheck", 1);
        }

    }


    public void PurchaseWitch()
    {
        if (WitchCheck == 1)
        {
            DisableAllSelectionImagesExceptSelected(3);
        }
        else if(TotalCandies >= 100)
        {
            DisableAllSelectionImagesExceptSelected(3);
            TotalCandies = TotalCandies - 100;
            PlayerPrefs.SetInt("TotalScore", TotalCandies);
            PlayerPrefs.SetInt("WitchCheck", 1);
        }

    }


    public void PurchaseMummy()
    {
        if (MummyCheck == 1)
        {
            DisableAllSelectionImagesExceptSelected(4);
        }
        else if(TotalCandies >= 150)
        {
            DisableAllSelectionImagesExceptSelected(4);
            TotalCandies = TotalCandies - 150;
            PlayerPrefs.SetInt("TotalScore", TotalCandies);
            PlayerPrefs.SetInt("MummyCheck", 1);
        }

    }



    public void PurchaseDracs()
    {
        if (DracsCheck == 1)
        {
            DisableAllSelectionImagesExceptSelected(5);
        }
        else if(TotalCandies >= 200)
        {
            DisableAllSelectionImagesExceptSelected(5);
            TotalCandies = TotalCandies - 200;
            PlayerPrefs.SetInt("TotalScore", TotalCandies);
            PlayerPrefs.SetInt("DracsCheck", 1);
        }

    }

    void DisableAllSelectionImagesExceptSelected( int x)
    {
        PlayerPrefs.SetInt("MonsterSelect", x);
        for(int i = 0;i<SelectionImage.Length; i++)
        {
            if (i == x)
            {
                SelectionImage[i].SetActive(true);
                continue;
            }
               
            SelectionImage[i].SetActive(false);
        }
    }



}
