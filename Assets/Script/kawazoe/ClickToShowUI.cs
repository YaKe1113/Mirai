using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToShowUI : MonoBehaviour
{
    // �\������UI�I�u�W�F�N�g
    public GameObject uiPanel;

    void Start()
    {
        // �V�[�����œ����UI�I�u�W�F�N�g���������Đݒ�
        if (uiPanel == null)
        {
            uiPanel = GameObject.Find("ui");
            Debug.Log("UIPanel ��������܂����B");
            uiPanel.GetComponent<CanvasGroup>().alpha = 1;
        }

        if (uiPanel == null)
        {
            Debug.LogError("UIPanel ��������܂���B�X�N���v�g�Ŏ����ݒ肷�邩�AInspector �Őݒ肵�Ă��������B");
        }

        // �V�[���J�n����UI���\���ɂ���
        //if (uiPanel != null)
        //{
        //    uiPanel.SetActive(false);
        //}
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform && uiPanel != null)
                {
                    uiPanel.SetActive(!uiPanel.activeSelf);
                    //targetObject.GetComponent;

                }
            }
        }
    }
}
