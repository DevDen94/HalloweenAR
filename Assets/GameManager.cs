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

    public int Kills;
    public int Deaths;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        Kills = 0;
        Deaths = 0;
    }

    // Update is called once per frame
    void Update()
    {
        KillsText.text = Kills + "";
        DeathText.text = Deaths +"";
    }
}
