using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyZone : MonoBehaviour
{

    public int EnemyArea = 10;
    int gamecount = 0;
    [SerializeField] private GameObject GameOverText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gamecount = 1;
            Time.timeScale = 0;
        }
    }


    //public void SetTarget(Transform target)
    //{
    //    this.target = target;
    //}

    //    private void OnTriggerStay(Collider col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {

    //        GameOverText.SetActive(true);
    //        Time.timeScale = 0;



    //    }
    //}


}
