using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class clear : MonoBehaviour
{
    //Inspectorでキャラクターとゴールオブジェクトの指定を出来る様にします。
    public GameObject chara;
    public GameObject gameclea;
    public AudioClip goal;
    AudioSource audioSource;

    private void OnTrigerEnter(Collider other)
    {
        //もしゴールオブジェクトのコライダーに接触した時の処理。
        if (other.name == chara.name)
        {
            gameclea.GetComponent<Text>();
            gameclea.SetActive(true);
            GetComponent<AudioSource>().Play();     //音を再生
        }
    }
}