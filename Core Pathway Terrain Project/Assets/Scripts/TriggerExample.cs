using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("The player has stepped on the staircase ...");
    }

}
