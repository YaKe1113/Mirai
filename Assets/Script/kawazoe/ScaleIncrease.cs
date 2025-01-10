using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleIncrease : MonoBehaviour
{
    private bool isScaled = false;      // �X�P�[���g�債�Ă��邩
    public Vector3 scaleIncrease = new Vector3(1.0f, 1.0f, 1.0f);    // �g��{��
    private Vector3 originalScale;      // ���̃T�C�Y��ۑ�

    // Start is called before the first frame update
    void Start()
    {
        // �����T�C�Y��ۑ�
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0)) // 0: ���N���b�N
        //{
        //    // �}�E�X�̈ʒu����Ray���΂�
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;

        //    // Ray�����������I�u�W�F�N�g�𔻒�
        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        // ���̃X�N���v�g���A�^�b�`����Ă���I�u�W�F�N�g���N���b�N�����ꍇ
        //        if (hit.transform == transform)
        //        {
        Debug.Log("Scale");
        // �T�C�Y��؂�ւ���
        if (!isScaled)
        {
            Debug.Log("fadsfasdfa");
            StartCoroutine(SmoothScale(originalScale + scaleIncrease));
        }

        isScaled = !isScaled; // ��Ԃ�؂�ւ���
        //        }
        //    }
        //}
    }
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0)) // 0: ���N���b�N
    //    {
    //        // �}�E�X�̈ʒu����Ray���΂�
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hit;

    //        // Ray�����������I�u�W�F�N�g�𔻒�
    //        if (Physics.Raycast(ray, out hit))
    //        {
    //            // ���̃X�N���v�g���A�^�b�`����Ă���I�u�W�F�N�g���N���b�N�����ꍇ
    //            if (hit.transform == transform)
    //            {
    //                // �T�C�Y��؂�ւ���
    //                if (!isScaled)
    //                {
    //                    Debug.Log("fadsfasdfa");
    //                    StartCoroutine(SmoothScale(originalScale + scaleIncrease));
    //                }

    //                isScaled = !isScaled; // ��Ԃ�؂�ւ���
    //            }
    //        }
    //    }
    //}

    IEnumerator SmoothScale(Vector3 targetScale)
    {
        float duration = 1.0f;      // �g��ɂ����鎞��
        Vector3 startScale = transform.localScale;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            transform.localScale = Vector3.Lerp(startScale, targetScale, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.localScale = targetScale;
    }
}

//public class ScaleIncrease : MonoBehaviour
//{
//    private bool isScaled = false;      // �X�P�[���g�債�Ă��邩
//    public Vector3 scaleIncrease = new Vector3(1.0f, 1.0f, 1.0f);    // �g��{��
//    private Vector3 originalScale;      // ���̃T�C�Y��ۑ�

//    // Start is called before the first frame update
//    void Start()
//    {
//        // �����T�C�Y��ۑ�
//        originalScale = transform.localScale;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0)) // 0: ���N���b�N
//        {
//            // �}�E�X�̈ʒu����Ray���΂�
//            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//            RaycastHit hit;

//            // Ray�����������I�u�W�F�N�g�𔻒�
//            if (Physics.Raycast(ray, out hit))
//            {
//                // ���̃X�N���v�g���A�^�b�`����Ă���I�u�W�F�N�g���N���b�N�����ꍇ
//                if (hit.transform == transform)
//                {
//                    // �T�C�Y��؂�ւ���
//                    if (!isScaled)
//                    {
//                        StartCoroutine(SmoothScale(originalScale + scaleIncrease));
//                    }

//                    isScaled = !isScaled; // ��Ԃ�؂�ւ���
//                }
//            }
//        }
//    }

//    IEnumerator SmoothScale(Vector3 targetScale)
//    {
//        float duration = 1.0f;      // �g��ɂ����鎞��
//        Vector3 startScale = transform.localScale;
//        float elapsedTime = 0f;

//        while (elapsedTime < duration)
//        {
//            transform.localScale = Vector3.Lerp(startScale, targetScale, elapsedTime / duration);
//            elapsedTime += Time.deltaTime;
//            yield return null;
//        }

//        transform.localScale = targetScale;
//    }
//}
