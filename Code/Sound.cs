using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public GameObject acık, kapalı;

    void Start()
    {
       // PlayerPrefs.SetInt("SesDurum", 1);
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("SesDurum") == 1)
        {
            kapalı.SetActive(false);
            acık.SetActive(true);
        }
        else {
            acık.SetActive(false);
            kapalı.SetActive(true);
        } }

    public void ses_durum(string durum)
    {
        if (durum == "ac")//ses kapama
        {
            acık.SetActive(false);
            kapalı.SetActive(true);
            PlayerPrefs.SetInt("SesDurum",0);
        }
        else if (durum == "kapalı")//ses açma
        {
            kapalı.SetActive(false);
            acık.SetActive(true);
            PlayerPrefs.SetInt("SesDurum", 1);
        }
      
    }
}
