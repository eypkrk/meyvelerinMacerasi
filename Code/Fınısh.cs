using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fınısh : MonoBehaviour
{
    public Button but;
    void Start()
    {
        but.onClick.AddListener(Scr);
    }
    void Scr()
    {
        Application.LoadLevel("Fınısh");
    }
}
