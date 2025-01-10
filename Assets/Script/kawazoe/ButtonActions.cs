using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActions : MonoBehaviour
{
    public Button investButton;  // �����{�^��
    public Button specialButton; // �K�E�Z�{�^��
    public GameObject targetObject; // �A�N�V�����Ώۂ̃I�u�W�F�N�g
    private bool isScaled = false;      // �X�P�[���g�債�Ă��邩
    public Vector3 scaleIncrease = new Vector3(1.0f, 1.0f, 1.0f);    // �g��{��
    private Vector3 originalScale;      // ���̃T�C�Y��ۑ�

    //public GameObject originalObject;  // �I���W�i���̃I�u�W�F�N�g
    //private GameObject cloneObject;    // �N���[���I�u�W�F�N�g

    void Start()
    {
        // �{�^���ɃN���b�N�C�x���g��ݒ�
        if (investButton != null)
        {
            investButton.onClick.AddListener(HandleInvestButton);
        }
        else
        {
            Debug.LogError("investButton ���ݒ肳��Ă��܂���B");
        }

        if (specialButton != null)
        {
            specialButton.onClick.AddListener(HandleSpecialButton);
        }
        else
        {
            Debug.LogError("specialButton ���ݒ肳��Ă��܂���B");
        }

        // �����T�C�Y�� targetObject ����擾
        originalScale = transform.localScale;

        //// �I���W�i���̃I�u�W�F�N�g���N���[��
        //cloneObject = Instantiate(originalObject, transform.position, transform.rotation);
    }

    // �����{�^�����N���b�N���ꂽ�Ƃ��̏���
    void HandleInvestButton()
    {
        // �N���[���I�u�W�F�N�g�̃X�P�[����ύX
        //if (cloneObject != null)
        //{
        //Debug.Log("�g��");
        //Vector3 targetScale = cloneObject.transform.localScale + scaleIncrease;
        //StartCoroutine(SmoothScale(cloneObject, targetScale));
        //}

        //// �T�C�Y��؂�ւ���
        //if (!isScaled)
        //{
        Debug.Log("�g��");
        StartCoroutine(SmoothScale(originalScale + scaleIncrease));
        //}

        isScaled = !isScaled; // ��Ԃ�؂�ւ���
    }

    // �K�E�Z�{�^�����N���b�N���ꂽ�Ƃ��̏���
    void HandleSpecialButton()
    {
        // �K�E�Z�̃A�N�V�����������ɋL�q
        Debug.Log("�K�E�Z�����I");
        // �K�v�ɉ����ē���ȃA�N�V������ǉ�
    }

    IEnumerator SmoothScale(Vector3 targetScale)
    {
        float duration = 0.5f; // �g��ɂ����鎞��
        Vector3 startScale = targetObject.transform.localScale;
        float elapsedTime = 0f;

        // ���X�ɃX�P�[����ύX
        while (elapsedTime < duration)
        {
            targetObject.transform.localScale = Vector3.Lerp(startScale, targetScale, elapsedTime / duration);
            elapsedTime += Time.deltaTime; // ���Ԃ����Z
            yield return null; // ���̃t���[���܂őҋ@
        }

        Debug.Log((targetScale));

        // �Ō�Ɋm���Ƀ^�[�Q�b�g�X�P�[���ɐݒ�
        targetObject.transform.localScale = targetScale;
    }

    IEnumerator SmoothScale(GameObject target, Vector3 targetScale)
    {
        float duration = 0.5f;
        Vector3 startScale = target.transform.localScale;
        float elapsedTime = 0f;

        // ���X�ɃX�P�[����ύX
        while (elapsedTime < duration)
        {
            target.transform.localScale = Vector3.Lerp(startScale, targetScale, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // �Ō�Ɋm���Ƀ^�[�Q�b�g�X�P�[���ɐݒ�
        target.transform.localScale = targetScale;
    }
}
