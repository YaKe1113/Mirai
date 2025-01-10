using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Billding3 : MonoBehaviour
{
    public GameObject buildingPrefab;       // ���݂��錚����Prefab
    private bool isConstructed = false;     // ���������ݍς݂��ǂ���
    private int Score = PlayerData.Instance.nScore;

    private void Update()
    {
        // score�����ɒB�����ꍇ
        if (PlayerData.Instance.nMoney > 3000 && !isConstructed)
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

            // �󂫒n��GameObject���폜
            Destroy(gameObject);

            isConstructed = true;
        }
    }
}