using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    private Animator animator;
    public AudioClip engine;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey("w"))
        //{
        //    transform.position += transform.forward * 0.1f;

        //    if (Input.GetKey("right"))
        //    {
        //        transform.Rotate(0, 0.5f, 0);
        //    }
        //    if (Input.GetKey("left"))
        //    {
        //        transform.Rotate(0, -0.5f, 0);
        //    }

        //}
        //else if (Input.GetKey("s"))
        //{
        //    transform.position -= transform.forward * 0.06f;

        //    if (Input.GetKey("right"))
        //    {
        //        transform.Rotate(0, -0.5f, 0);
        //    }
        //    if (Input.GetKey("left"))
        //    {
        //        transform.Rotate(0, 0.5f, 0);
        //    }

        //}
        //else if (Input.GetKey("d"))
        //{
        //    transform.position += transform.right * 0.01f;
        //}
        //else if (Input.GetKey("a"))
        //{
        //    transform.position -= transform.right * 0.01f;
        //}

        //コントローラー操作
        if (Input.GetAxisRaw("Vertical") < 0)
        {
<<<<<<< HEAD
            transform.position += transform.forward * 1f;
=======
            //上に傾いている
            transform.position -= transform.forward * 0.06f;
            GetComponent<AudioSource>().Play();     //音を再生
>>>>>>> 2b5c3dbc6809b62aab262a29fb0509b96b554eff

            //右stick
            if (Input.GetAxisRaw("Horizontal2") < 0)
            {
                //左に傾いている
                transform.Rotate(0, 0.5f, 0);
            }
            else if (0 < Input.GetAxisRaw("Horizontal2"))
            {
<<<<<<< HEAD
                transform.Rotate(0, 0.4f, 0);
=======
                //右に傾いている
                transform.Rotate(0, -0.5f, 0);
>>>>>>> 2b5c3dbc6809b62aab262a29fb0509b96b554eff
            }
            else
            {
<<<<<<< HEAD
                transform.Rotate(0, -0.4f, 0);
=======
                //左右方向には傾いていない
>>>>>>> 2b5c3dbc6809b62aab262a29fb0509b96b554eff
            }

        }
        else if (0 < Input.GetAxisRaw("Vertical"))
        {
<<<<<<< HEAD
            transform.position -= transform.forward * 1f;
=======
            //下に傾いている
            transform.position += transform.forward * 0.13f;
>>>>>>> 2b5c3dbc6809b62aab262a29fb0509b96b554eff

            if (Input.GetAxisRaw("Horizontal2") < 0)
            {
<<<<<<< HEAD
                transform.Rotate(0, -0.4f, 0);
=======
                //左に傾いている
                transform.Rotate(0, -0.5f, 0);
>>>>>>> 2b5c3dbc6809b62aab262a29fb0509b96b554eff
            }
            else if (0 < Input.GetAxisRaw("Horizontal2"))
            {
<<<<<<< HEAD
                transform.Rotate(0, 0.4f, 0);
=======
                //右に傾いている
                transform.Rotate(0, 0.5f, 0);
            }
            else
            {
                //左右方向には傾いていない
>>>>>>> 2b5c3dbc6809b62aab262a29fb0509b96b554eff
            }

        }
        else
        {
            //上下方向には傾いていない
        }

    }



}