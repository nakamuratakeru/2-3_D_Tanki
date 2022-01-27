using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour
{
    public GameObject chara;
    public GameObject gameclear;
    public GameObject return_title;
    
    //プレイヤーが当たり判定に入った時の処理
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameClear");
            //gameclear.GetComponent<Text>();
            //gameclear.SetActive(true);
            //return_title.GetComponent<Button>();
            //return_title.SetActive(true);
            //Debug.Log("当たってるyo");
        }
    }
}