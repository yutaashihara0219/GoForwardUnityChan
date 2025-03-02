using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//�X�N���v�g�ŃV�[���Ɋւ���N���X�iSceneManager.LoadScene("SampleScene");�j���g������

public class UIController : MonoBehaviour
{
    // �Q�[���I�[�o�[�e�L�X�g
    private GameObject gameOverText;
    // �Q�[���I�[�o�[�̔���
    private bool isGameOver = false;

    // ���s�����e�L�X�g
    private GameObject runLengthText;
    // ����������
    private float len = 0;
    // ���鑬�x
    private float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        // �V�[���r���[����I�u�W�F�N�g(UIText)�̎��̂���������
        this.gameOverText = GameObject.Find("GameOver");
        this.runLengthText = GameObject.Find("RunLength");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isGameOver == false)
        {
            // �������������X�V����
            this.len += this.speed * Time.deltaTime;

            // ������������\������
            this.runLengthText.GetComponent<Text>().text = "Distance:  " + len.ToString("F2") + "m";
        }

        // �Q�[���I�[�o�[�ɂȂ����ꍇ
        if (this.isGameOver == true)
        {
            // �N���b�N���ꂽ��V�[�������[�h����
            if (Input.GetMouseButtonDown(0))
            {
                //SampleScene��ǂݍ���
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void GameOver()
    {
        // �Q�[���I�[�o�[�ɂȂ����Ƃ��ɁA��ʏ�ɃQ�[���I�[�o��\������
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;
    }
}
