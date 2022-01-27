using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class stand : MonoBehaviour
{
    Slider _slider;

    float max_hp = 100;
    float _hp = 100;

    // Start is called before the first frame update
    void Start()
    {
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _slider.value = max_hp;
        }
    }
}
