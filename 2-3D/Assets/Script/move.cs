using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    private Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += transform.forward * 0.1f;

            if (Input.GetKey("right"))
            {
                transform.Rotate(0, 0.2f, 0);
            }
            if (Input.GetKey("left"))
            {
                transform.Rotate(0, -0.2f, 0);
            }

        }
        else if (Input.GetKey("s"))
        {
            transform.position -= transform.forward * 0.1f;

            if (Input.GetKey("right"))
            {
                transform.Rotate(0, -2f, 0);
            }
            if (Input.GetKey("left"))
            {
                transform.Rotate(0, 0.2f, 0);
            }

        }
        //else if (Input.GetKey("d"))
        //{
        //    transform.position += transform.right * 0.01f;
        //}
        //else if (Input.GetKey("a"))
        //{
        //    transform.position -= transform.right * 0.01f;
        //}

    }



}