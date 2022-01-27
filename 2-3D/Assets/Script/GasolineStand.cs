using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class GasolineStand : MonoBehaviour
{
    public GameObject chara;
    Slider _slider;
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    float _hp = 100;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _hp += 100f;
            Debug.Log("当たってる");
          
        }
        // HPゲージに値を設定
        _slider.value = _hp;
    }
    //// HPゲージに値を設定
    //_slider.value = _hp;
}