using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Vehicle vehicle;

    // Start is called before the first frame update
    void Start()
    {
        vehicle = GetComponent<Vehicle>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            vehicle.Gas();
        }

        if (Input.GetKey(KeyCode.S))
        {
            vehicle.Brake();
        }

        var turnSide = Input.GetAxis("Horizontal");
        if (turnSide != 0)
        {
            vehicle.Turn(turnSide);
        }
    }
}
