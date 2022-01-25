using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineSound : MonoBehaviour
{
    public AudioClip engine;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //L Stick
        //float lsh = Input.GetAxis("L_Stick_H");
        //float lsv = Input.GetAxis("L_Stick_V");
        //if ((lsh != 0) || (lsv != 0))   //多分Lスティックを動かしたら
        //{
        //    GetComponent<AudioSource>().Play();     //音を再生
        //    Debug.Log("L stick:" + lsh + "," + lsv);    //入力できてるか確認
        //}
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<AudioSource>().Play();     //音を再生
        }
    }
}
