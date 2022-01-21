using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{

    void Start()
    {

    }
    void Update()
    {
        if(Input.GetKeyDown("joystick button 1"))
        {
            Debug.Log("button1");
        }
        bool Startkettei = Input.GetKeyDown("joystick button 0");
        if (Startkettei == true)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}