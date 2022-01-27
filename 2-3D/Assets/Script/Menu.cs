using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{

    // ボタンが押された場合、今回呼び出される関数
    void Update()
    {
        //if (Input.GetKeyDown("joystick button 1"))
        //{
        //    Debug.Log("button1");
        //}
        bool Startkettei = Input.GetKeyDown("joystick button 0");
        if (Startkettei == true)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
    
