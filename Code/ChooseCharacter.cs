using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCharacter : MonoBehaviour
{
    private List<GameObject> models;
    public bool isGame;
    void Start()
    {
        if (isGame)
        {
            int selectionIndex;
            selectionIndex = PlayerPrefs.GetInt("index", 0);
            models = new List<GameObject>();
            foreach (Transform t in transform)
            {
                models.Add(t.gameObject);
                t.gameObject.SetActive(false);
            }
            models[selectionIndex].SetActive(true);
        }
    }
    public void Select(int index)
    {
        if (index == PlayerPrefs.GetInt("index", 0))
            return;
        if (index < 0)
            return;
        PlayerPrefs.SetInt("index", index);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
