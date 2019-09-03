using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject food;
    int RandomSpawn;
    GM gm;

    private void Start()
    {
        gm = GameObject.Find("GM").GetComponent<GM>();
        InvokeRepeating("InstantiateBall", 1f, 0.2f);
        InstantiateBall();
    }

    public void InstantiateBall()
    {
        if(gm.gameOver == false)
        {
            Instantiate(food, new Vector3(Random.Range(0, 0), 5, Random.Range(0, 0)), transform.rotation);
        }

    }

}
