using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEscript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Engine);
        }
        //if (Input.GetKeyDown(KeyCode.H))
        //{
        //    TinyAudio.PlaySE(TinyAudio.SE.Hit);
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    TinyAudio.PlaySE(TinyAudio.SE.Magic);
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Object") //Objectタグの付いたゲームオブジェクトと衝突したか判別
        {
            TinyAudio.PlaySE(TinyAudio.SE.Hit); 
            //Destroy(this.gameObject); //衝突したゲームオブジェクトを削除
        }
    }
}
