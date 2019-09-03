using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bomb;
    int RandomSpawn;
    GM gm;

    private void Start()
    {
        gm = GameObject.Find("GM").GetComponent<GM>();
        InvokeRepeating("InstantiateBall", 1f, 1f);
        InstantiateBall();
    }

    public void InstantiateBall()
    {
        if(gm.gameOver == false)
        {
            Instantiate(bomb, new Vector3(Random.Range(0, 0), 6, Random.Range(0, 0)), transform.rotation);
        }
    }

}
