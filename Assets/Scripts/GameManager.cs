using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text LastText;

    int last;

    public void Start()
    {
        last = PlayerPrefs.GetInt("Roulette");
        LastText.text = "Last: " + last.ToString();
    }
    public void Spin()
    {
        
#pragma warning disable CS0618 // Tür veya üye artık kullanılmıyor
        Application.LoadLevel("Roulette");
#pragma warning restore CS0618 // Tür veya üye artık kullanılmıyor
    }


    public void BackMenuButton()
    {
#pragma warning disable CS0618 // Tür veya üye artık kullanılmıyor
        Application.LoadLevel("Menu");
#pragma warning restore CS0618 // Tür veya üye artık kullanılmıyor
    }
}
