using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fallgameover : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameover;

    // Update is called once per frame
        void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.tag == "GameOver")
            {
            SceneManager.LoadScene("GameOver");
        }
        }

}
