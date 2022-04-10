using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    public Button but;
    public Button ex;
    public Button sc;
    public Button ch;
    void Start()
    {
        but.onClick.AddListener(Ply);
        sc.onClick.AddListener(Sc);
        ex.onClick.AddListener(Ex);
        ch.onClick.AddListener(Cho);
    }
    void Ply()
    {
        Application.LoadLevel("Story");
    }
    void Ex()
    {
        Application.Quit();
    }
    void Sc()
    {
        Application.LoadLevel("Score");
    }
    void Cho()
    {
        Application.LoadLevel("Characters");
    }
}
