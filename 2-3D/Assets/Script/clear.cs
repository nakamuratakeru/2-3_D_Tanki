using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class clear : MonoBehaviour
{
    public GameObject Chara;
    public GameObject gameclea;
    void Start()
    {
       
    }


    void ONCollisonEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameclea.GetComponent<Text>();
            gameclea.SetActive(true);
        }
    }
}