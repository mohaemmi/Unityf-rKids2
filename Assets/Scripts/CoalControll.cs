using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalControll : MonoBehaviour
{
    void OnTriggerEnter ()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    void OnTriggerExit ()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }


}
