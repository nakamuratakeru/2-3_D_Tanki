﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarEnemy : MonoBehaviour
{
    CharacterController Controller;
    Transform Target;
    GameObject Player;

    [SerializeField]
    float MoveSpeed = 2.0f;
    int DetecDist = 8;
    bool InArea = false;


    // Use this for initialization
    void Start()
    {

        // プレイヤータグの取得
        Player = GameObject.FindWithTag("Player");
        Target = Player.transform;

        Controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        if (InArea)
        {
            // プレイヤーのほうを向かせる
            this.transform.LookAt(Target.transform);

            // キューブとプレイヤー間の距離を計算
            Vector3 direction = Target.position - this.transform.position;
            direction = direction.normalized;

            // プレイヤー方向の速度を作成
            Vector3 velocity = direction * MoveSpeed;

            // プレイヤーがジャンプしたときにキューブが浮かないようにy速度を0に固定しておく(空中も追従させたい場合は不要)
            velocity.y = 0.0f;

            // キューブを動かす
            Controller.Move(velocity * Time.deltaTime);
        }

        //プレイヤーとキューブ間の距離を計算
        Vector3 Apos = this.transform.position;
        Vector3 Bpos = Target.transform.position;
        float distance = Vector3.Distance(Apos, Bpos);

        // 距離がDetecDistの設定値未満の場合は検知フラグをfalseにする。
        if (distance > DetecDist)
        {
            InArea = false;
        }
    }

    // プレイヤーが検知エリアにはいたら検知フラグをtrueにする。
    private void OnTriggerEnter(Collider other)
    {
        InArea = true;
    }
    //    public Transform[] points;
    //    private int destpoint = 0;
    //    private NavMeshAgent agent;
    //    public GameObject target;
    //    private bool inArea = false;
    //    public float chaspeeed = 0.05f;
    //    void Start()
    //    {
    //        agent = GetComponent<NavMeshAgent>();
    //        agent.autoBraking = false;
    //        GotoNextPoint();
    //    }

    //    // Update is called once per frame
    //    void Update()
    //    {
    //        if(agent.remainingDistance < 0.5f)
    //        {
    //            GotoNextPoint();
    //        }



    //        if(inArea == true && target.activeInHierarchy == true)
    //        {
    //            agent.destination = target.transform.position;
    //            //EneChasing();
    //        }
    //    }

    //    void GotoNextPoint()
    //    {
    //        if (points.Length == 0)
    //            return;

    //        agent.destination = points[destpoint].position;
    //        destpoint = (destpoint + 1) % points.Length;
    //    }

    //    private void OnTriggerEnter(Collider other)
    //    {
    //        if(other.gameObject.tag == "Player")
    //        {
    //            inArea = true;
    //            target = other.gameObject;
    //            //GetComponent<Renderer>().material.color = new Color(255f / 255f, 65f / 255f, 26f / 255f, 255f / 255f);
    //            //EneChasing();
    //        }
    //    }

    //    //private void OnTriggerExit(Collider other)
    //    //{
    //    //    if(other.gameObject.tag == "Player")
    //    //    {
    //    //        inArea = true;
    //    //        GetComponent<Renderer>().material.color = origColor;
    //    //        GotoNextPoint();
    //    //    }
    //    //}

    //    //public void EneChasing()
    //    //{
    //    //    transform.position += transform.forward * chaspeeed;
    //    //}
}
