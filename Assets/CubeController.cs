using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;

    // �n�ʂƂԂ��������̉�
    public AudioClip se1;
    // �n�ʂƂԂ��������̉�
    public AudioClip se2;
    // AudioClip�Đ��p
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        // �I�[�f�B�I�̃R���|�[�l���g���擾
        this.audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //�n�ʂƏՓ˂����ꍇ
        if(collision.gameObject.tag == "Ground")
        {
            //�I�[�f�B�I�Đ�
            this.audioSource.PlayOneShot(se1);
        }

        //�L���[�u���m�ŏՓ˂����ꍇ
        if (collision.gameObject.tag == "Cube")
        {
            //�I�[�f�B�I�Đ�
            this.audioSource.PlayOneShot(se2);
        }
    }
}
