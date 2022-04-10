using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choose : MonoBehaviour
{
    public Text ChooseTx;
    public Button elma;
    public Button portakal;
    public Button setalı;
    public Button erık;
    public Button karpuz;
    public Button kavun;
    public Button menu;
    // Start is called before the first frame update
    void Start()
    {
        elma.onClick.AddListener(el);
        portakal.onClick.AddListener(pr);
        setalı.onClick.AddListener(se);
        erık.onClick.AddListener(se);
        karpuz.onClick.AddListener(se);
        kavun.onClick.AddListener(se);
        menu.onClick.AddListener(me);

    }
    void el()
    {
        Application.LoadLevel("MainMenu");
    }
    void pr()
    {
        Application.LoadLevel("MainScene");
    }
    void se()
    {
        ChooseTx.text = "YOU DO NOT CHOOSE";
    }
    void me()
    {
        Application.LoadLevel("MainMenu");
    }


}
