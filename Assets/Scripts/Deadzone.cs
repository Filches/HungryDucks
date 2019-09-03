using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadzone : MonoBehaviour
{
    GM gm;

    private void Start()
    {
        gm = GameObject.Find("GM").GetComponent<GM>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (!gm.gameOver)
        {
            if (gameObject.tag == "WhiteDuck")
            {
                if (col.gameObject.tag == "Food")
                {
                    gm.GainPointWhite();
                    Destroy(col.gameObject);
                }

                if (col.gameObject.tag == "Bomb")
                {
                    gm.LoseLifeWhite();
                    Destroy(col.gameObject);
                }
            }

            if (gameObject.tag == "BrownDuck")
            {
                if (col.gameObject.tag == "Food")
                {
                    gm.GainPointBrown();
                    Destroy(col.gameObject);
                }

                if (col.gameObject.tag == "Bomb")
                {
                    gm.LoseLifeBrown();
                    Destroy(col.gameObject);
                }
            }

            if (gameObject.tag == "GreenDuck")
            {
                if (col.gameObject.tag == "Food")
                {
                    gm.GainPointGreen();
                    Destroy(col.gameObject);
                }

                if (col.gameObject.tag == "Bomb")
                {
                    gm.LoseLifeGreen();
                    Destroy(col.gameObject);
                }
            }

            if (gameObject.tag == "YellowDuck")
            {
                if (col.gameObject.tag == "Food")
                {
                    gm.GainPointYellow();
                    Destroy(col.gameObject);
                }

                if (col.gameObject.tag == "Bomb")
                {
                    gm.LoseLifeYellow();
                    Destroy(col.gameObject);
                }
            }
        }
    }
}
