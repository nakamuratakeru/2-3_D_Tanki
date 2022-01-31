using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Penalty : MonoBehaviour
{
    Slider _slider;

    float hit_hp = 10;
    float _hp = 100;

    // Start is called before the first frame update
    void Start()
    {
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            _slider.value -= hit_hp;
        }
    }
}