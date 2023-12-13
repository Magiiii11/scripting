using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public floatspeeddFactor = 2.5f;

     void OnTriggerEnter(Collider)
     {

        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
     }  

    void OnTiggerExit(Collider other)
    {

        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
