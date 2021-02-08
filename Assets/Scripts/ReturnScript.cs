using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnScript : MonoBehaviour
{
    [SerializeField]
    Transform myTarget;

    [SerializeField]
    WheelScript wheelScript;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Ball")
        {
            wheelScript.target = myTarget;
        }
    }

}
