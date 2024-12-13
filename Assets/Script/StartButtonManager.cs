using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButtonManager : MonoBehaviour
{
    //public void StartButton()
    //{
    //    //SceneManager.LoadScene("Game");
    //}

    public float speed = 1.0f;
    private Image image;
    private float time;

    void Start()
    {
        image = this.gameObject.GetComponent<Image>();
    }

    void Update()
    {
        image.color = GetAlphaColor(image.color);
    }

    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time);

        return color;
    }
}