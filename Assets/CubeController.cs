using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    // 地面とぶつかった時の音
    public AudioClip se1;
    // 地面とぶつかった時の音
    public AudioClip se2;
    // AudioClip再生用
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        // オーディオのコンポーネントを取得
        this.audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //地面と衝突した場合
        if(collision.gameObject.tag == "Ground")
        {
            //オーディオ再生
            this.audioSource.PlayOneShot(se1);
        }

        //キューブ同士で衝突した場合
        if (collision.gameObject.tag == "Cube")
        {
            //オーディオ再生
            this.audioSource.PlayOneShot(se2);
        }
    }
}
