using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{
    public Text scoreTx;
    public Text highScoreTx;
    private int score = 0;
    public GameObject character;
    private float isIncrease = 0.0f;
    public Text gameOverTx;
    public Button pause,restart,menu;
    public Text btnTx;
    private bool isPause;
    public int speed = 1;
    public static GameControl instance;
    private float yres, ylev;
    public float resY, levY;

    void Start()
    {
        yres = restart.transform.position.y;
        ylev = menu.transform.position.y;
        highScoreTx.text = "High Score :" + PlayerPrefs.GetInt("high_score");
        scoreTx.text = "Score: " + score;
        instance = GetComponent<GameControl>();
        pause.onClick.AddListener(paus);
        restart.onClick.AddListener(res);
        menu.onClick.AddListener(main);
        notShow();

    }
    void Update()
    {
        if (character.transform.position.y < 2.5)
            gameOver();
        if (character.transform.position.x - isIncrease > 2)
        {
            isIncrease = character.transform.position.x;
            score++;
            scoreTx.text = "Score: " + score;
        }
        if (character.transform.position.x > 1314)
            hıt();
    }
    public void gameOver()
    {
        gameOverTx.text = "GAME OVER";
        if (score > PlayerPrefs.GetInt("high_score"))
            PlayerPrefs.SetInt("high_score", score);
        highScoreTx.text = "High Score :" + PlayerPrefs.GetInt("high_score");
        speed = 0;
        show();
    }
    void paus()
    {
        if (isPause)
            notShow();
        else
            show();
    }

    void notShow()
    {
        menu.transform.position = new Vector3(menu.transform.position.x, levY, menu.transform.position.z);
        restart.transform.position = new Vector3(restart.transform.position.x, resY, menu.transform.position.z);
        btnTx.text = "X";
        isPause = false;
        speed = 1;
    }

    void show()
    {
        menu.transform.position = new Vector3(menu.transform.position.x, ylev, menu.transform.position.z);
        restart.transform.position = new Vector3(restart.transform.position.x, yres, menu.transform.position.z);
        btnTx.text = "X";
        isPause = true;
        speed = 0;
    }
    void res()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    void main()
    {
        Application.LoadLevel("MainMenu");
    }
    void hıt()
    {
        Application.LoadLevel("Score");
    }

}
