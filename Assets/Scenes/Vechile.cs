using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vechile : MonoBehaviour
{
    public void Brake()
    {
    
    }

    public void Gas()
    {
        transform.position += transform.forward * Time.deltaTime;
    }

    public void Turn(float amount)
    {
        transform.Rotate(0, amount, 0);
    }
}
