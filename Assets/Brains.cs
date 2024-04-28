using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brains : MonoBehaviour
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
        vehicle.Gas();
        vehicle.Turn(Random.Range(-1f, 1f));
    }
}
