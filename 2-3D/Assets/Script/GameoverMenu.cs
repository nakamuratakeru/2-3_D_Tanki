using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameoverMenu : MonoBehaviour
{

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            SceneManager.LoadScene("GameScene");
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            SceneManager.LoadScene("Title");
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            Application.Quit();
        }
    }
}