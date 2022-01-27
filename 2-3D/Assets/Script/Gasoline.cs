using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    float max_hp = 100;
    float _hp = 100;
    void Update()
    {
        // ガソリン残量を減らす
        _hp -= 0.040f;
        if (_hp < 0)
        {
                SceneManager.LoadScene("GameOver");
        }

        // HPゲージに値を設定
        _slider.value = _hp;

    }

}
