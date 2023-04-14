using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.name + " : Enter");
        Destroy(other.transform.gameObject);
    }

    /*private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.transform.name + ":Exit");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.transform.name + ":Stay");
    }*/
}
