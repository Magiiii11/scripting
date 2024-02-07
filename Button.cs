using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator button;
    public Animator toOpen;

    void Start()
    {
        button.enebled = false; 
    }

    private void OnTriggerEnter(Collider other)
    {
        button.enebled = true;
        toOpen.enebled = true;
    }
}
