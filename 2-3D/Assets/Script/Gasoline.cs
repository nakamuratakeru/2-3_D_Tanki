using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Gasoline : MonoBehaviour
{
    public GameObject chara;
    public GameObject gameover;
    Slider _slider;
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    float _hp = 100;
    void Update()
    {
        // ガソリン残量を減らす
        _hp -= 0.020f;
        if (_hp < 0)
        {
            gameover.GetComponent<Text>();
            gameover.SetActive(true);
        }

        // HPゲージに値を設定
        _slider.value = _hp;
    }
}
