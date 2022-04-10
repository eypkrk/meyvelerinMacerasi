using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story : MonoBehaviour
{
    public Button st;
    // Start is called before the first frame update
    void Start()
    {
        st.onClick.AddListener(Sto);
    }

    // Update is called once per frame
    void Sto()
    {
        Application.LoadLevel("Try");
    }
}
