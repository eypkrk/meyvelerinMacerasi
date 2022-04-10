using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed;
    private Animator anim;
    private bool isFloor = false;//yerdeyken zıpla
    private bool isSecond = false;
    public JumpBut jumpButton;
    public DownBut downButton;
    public AudioSource aud;
    private void Awake()
    {
        anim = GetComponent<Animator>();//getcomponenet içindikeleri al
        rb2d = GetComponent<Rigidbody2D>();//addforce fizik ekleme için
        jumpButton = FindObjectOfType<JumpBut>();
        downButton = FindObjectOfType<DownBut>();
    }
    void Update()
    {
        if (isFloor)
        {
            if (jumpButton.Pressed && GameControl.instance.speed == 1)
            {
                aud.Play();
                rb2d.AddForce(new Vector2(300, 450));
                isFloor = false;
                anim.SetTrigger("spin");
            }
            else
            {
                rb2d.velocity = new Vector2(0,0);
            }
        }
        else
        {
            if (isSecond && downButton.Pressed)
            {
                aud.Play();
                rb2d.AddForce(new Vector2(250, 550));//zıplama
                 anim.SetTrigger("spin");

                isSecond = false;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        isFloor = true;//yere çarparsa zıpla çarpmazsa zıplama
        isSecond = true;
    }
    void OnCollisionExit2D(Collision2D other)
    {
        isFloor = false;//yere çarparsa zıpla çarpmazsa zıplama
    }
}
