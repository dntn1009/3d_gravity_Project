using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMovement2 : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 200, 40), "ExamplePhyscialScene"))
        {
            Debug.Log("Å¬¸¯");
            SceneManager.LoadScene(0);
        }
    }
}
