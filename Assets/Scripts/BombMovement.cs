using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float ballThrust;

    // Start is called before the first frame update
    void Start()
    {
        new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(new Vector3(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180)) * 10, ForceMode.Impulse);
    }
}
