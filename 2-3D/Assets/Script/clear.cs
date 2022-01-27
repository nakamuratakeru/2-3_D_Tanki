using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour
{
    public GameObject chara;
<<<<<<< HEAD
    public GameObject gameclear;
    public GameObject return_title;
    
    //プレイヤーが当たり判定に入った時の処理
    void OnTriggerEnter(Collider other)
=======
    public GameObject gameclea;
    public AudioClip goal;
    AudioSource audioSource;

    private void OnTrigerEnter(Collider other)
>>>>>>> 2b5c3dbc6809b62aab262a29fb0509b96b554eff
    {
        if (other.gameObject.tag == "Player")
        {
<<<<<<< HEAD
            SceneManager.LoadScene("GameClear");
            //gameclear.GetComponent<Text>();
            //gameclear.SetActive(true);
            //return_title.GetComponent<Button>();
            //return_title.SetActive(true);
            //Debug.Log("当たってるyo");
=======
            gameclea.GetComponent<Text>();
            gameclea.SetActive(true);
            GetComponent<AudioSource>().Play();     //音を再生
>>>>>>> 2b5c3dbc6809b62aab262a29fb0509b96b554eff
        }
    }
}