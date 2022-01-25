using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSound : MonoBehaviour
{
    // ぶつかった時の音
    public AudioClip se;

    // ぶつかった時に音を鳴らす
    void OnCollisionEnter(Collision col)
    {
        AudioSource.PlayClipAtPoint(se, transform.position);    //ぶつかった場所で音を再生
    }
}
