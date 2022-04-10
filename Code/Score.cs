using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text highScoreTx;
    public Button but;
    void Start()
    {
        
        but.onClick.AddListener(Scr);
        highScoreTx.text = "" + PlayerPrefs.GetInt("high_score");
    }
    void Scr()
    {
        Application.LoadLevel("MainMenu");
    }
}
