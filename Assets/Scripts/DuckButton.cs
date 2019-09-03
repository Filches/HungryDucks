﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckButton : MonoBehaviour
{
    public KeyCode DuckButt;
    Animator anim;
    GM gm;

    void Start()
    {
        anim = GetComponent<Animator>();
        gm = GameObject.Find("GM").GetComponent<GM>();
    }

    void Update()
    {if(gm.gameOver == false)
        {
            if (Input.GetKeyDown(DuckButt))
            {
                anim.SetBool("PoopBool", true);
            }

            if (Input.GetKeyUp(DuckButt))
            {
                anim.SetBool("PoopBool", false);
            }

            if (gameObject.tag == "WhiteDuck")
            {
                if (gm.WhiteLives <= 0)
                {
                    Destroy(gameObject);
                }
            }

            if (gameObject.tag == "BrownDuck")
            {
                if (gm.BrownLives <= 0)
                {
                    Destroy(gameObject);
                }
            }

            if (gameObject.tag == "GreenDuck")
            {
                if (gm.GreenLives <= 0)
                {
                    Destroy(gameObject);
                }
            }

            if (gameObject.tag == "YellowDuck")
            {
                if (gm.YellowLives <= 0)
                {
                    Destroy(gameObject);
                }
            }
        }


    }
}
