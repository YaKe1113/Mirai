using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPCManager : MonoBehaviour
{
    public GameObject NPC_00;
    private int nInterval = 60;  //�X�e�[�W�Ȃǂɂ����Pop�̃C���^�[�o���͕ς��̂ł���p
    private int nCntInterval = 0;  //�C���^�[�o���J�E���g�p

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //�n�ʂ̎�O�̒[�Ɖ��̒[�̍��W X���W�ł�
    int StartPos = 0;
    //int EndPos = 100;

    nCntInterval++;
        //�X�e�[�W�ɂ���ďꍇ����
        switch (PlayerData.Instance.nCurrentStage)
        {
            case 0:
                
                if(nCntInterval>nInterval)
                {
                    nCntInterval = 0;
                    Instantiate(NPC_00, new Vector3(StartPos, 0, Random.Range(0.0f, 10.0f)), Quaternion.Euler(0, 90, 0));
                  //  Debug.Log("tt");
                }
                break;

        }
        
    }
}
