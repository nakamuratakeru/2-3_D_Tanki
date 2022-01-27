﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEfect : MonoBehaviour
{
    public GameObject particleObject;   //エフェクトを入れるやつ

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Object") //Objectタグの付いたゲームオブジェクトと衝突したか判別
        {
            Instantiate(particleObject, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            //Destroy(this.gameObject); //衝突したゲームオブジェクトを削除
        }
    }
}
