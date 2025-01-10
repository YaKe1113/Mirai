using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;

    public int nMoney = 777;  // �����̂���
    public int nScore = 0;  // ������Score
    public float nTime = 0;    //���ԊǗ�  ���v�Ƃ��\�����鎞�p
    //�X�e�[�W�Ǘ��p   �X�e�[�W�����W�x�̂���
    public int nCurrentStage = 0;  
    public int nMaxStage = 3;



    void Awake()
    {
        // �V���O���g��
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        nTime+=0.1f;
    }


    // �����𑝂₷���\�b�h
    public void AddMoney(int amount)
    {
        nMoney += amount;
       
    }

    public void AddScore(int amount)
    {
        nScore += amount;
    }
}
