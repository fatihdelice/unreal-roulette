using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public void PlayButton()
    {
#pragma warning disable CS0618 // Tür veya üye artık kullanılmıyor
        Application.LoadLevel("Game");
#pragma warning restore CS0618 // Tür veya üye artık kullanılmıyor
    }
}
