using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fallgameover : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameover;

    // Update is called once per frame
        void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.tag == "GameOver")
            {
                gameover.GetComponent<Text>();
                gameover.SetActive(true);
            }
        }

}
