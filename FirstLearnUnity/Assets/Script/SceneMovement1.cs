using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMovement1 : MonoBehaviour
{
    void OnGUI()
    {
        if(GUI.Button(new Rect(0, 0, 200, 40), "ExamplePhyscialScene"))
        {
            Debug.Log("Å¬¸¯");
            SceneManager.LoadScene(2);
        }

        if(GUI.Button(new Rect(Screen.width - 200, 0, 200, 400), "Change to ObjectScene"))
        {
            //SceneManager.LoadScene(2);
        }
    }
}
