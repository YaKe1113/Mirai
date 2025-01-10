using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Billding1 : MonoBehaviour
{
    public GameObject buildingPrefab;       // ���݂��錚����Prefab
    private bool isConstructed = false;     // ���������ݍς݂��ǂ���
    private int Score = PlayerData.Instance.nScore;


    void Start()
    {

    }

    void Update()
    {
        // score�����ɒB�����ꍇ
        if (PlayerData.Instance.nMoney > 1000 && !isConstructed)
        {
            ConstructBuilding();
        }

    }

    private void ConstructBuilding()
    {
        if (buildingPrefab != null)
        {
            // ���݂̋󂫒n�̈ʒu�Ɍ�����ݒu
            Instantiate(buildingPrefab, transform.position, Quaternion.identity);

            Debug.Log("!!!!!");
            // �󂫒n��GameObject���폜
            Destroy(gameObject);

            isConstructed = true;
        }
    }

}