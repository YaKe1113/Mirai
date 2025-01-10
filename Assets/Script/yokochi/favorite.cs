using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class favorite : MonoBehaviour
{
    [SerializeField] Texture UirouTex = default;
    [SerializeField] Texture MisokatuTex = default;
    [SerializeField] Texture BigEyeTex = default;
    [SerializeField] Texture BrainwashingTex = default;
    Texture texture;
    Material material;

    GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        SetFavoriteTex();
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
    }

    public void SetFavoriteTex()
    {
        // material�擾
        material = this.GetComponent<MeshRenderer>().material;
        // �e�N�X�`���̎擾
        texture = material.GetTexture("_MainTex");

        obj = transform.root.gameObject;

        Debug.Log(obj.GetComponent<human>().GetFavoriteFood());
        switch (obj.GetComponent<human>().GetFavoriteFood())
        {
            case Store.food_type.uirou:
                // �e�N�X�`���̕ύX
                material.SetTexture("_MainTex", UirouTex);
                break;
            case Store.food_type.misokatu:
                // �e�N�X�`���̕ύX
                material.SetTexture("_MainTex", MisokatuTex);
                break;
            case Store.food_type.BigEye:
                // �e�N�X�`���̕ύX
                material.SetTexture("_MainTex", BigEyeTex);
                break;
        }
    }

    public void SetBrainwashingTex()
    {
        // material�擾
        material = this.GetComponent<MeshRenderer>().material;

        // �e�N�X�`���̎擾
        texture = material.GetTexture("_MainTex");

        // �e�N�X�`���̕ύX
        material.SetTexture("_MainTex", BrainwashingTex);

        Debug.Log("tanomu~");
    }
}