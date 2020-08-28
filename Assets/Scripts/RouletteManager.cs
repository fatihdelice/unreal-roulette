using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RouletteManager : MonoBehaviour
{
    [SerializeField]
    private Text RouletteSonucText;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip SpinSound;

    public GameObject RakkamPanel;
    public GameObject Ball;

    public GameObject Green;
    public GameObject Red;
    public GameObject Black;


    int RakamPanelTimer;
    bool sureSaysinmi;


    void Start()
    {
        RakamPanelTimer = 8;
        sureSaysinmi = true;
        audioSource.PlayOneShot(SpinSound);
        RakkamPanel.SetActive(false);
        Green.SetActive(false);
        Red.SetActive(false);
        Black.SetActive(false);
        Ball.SetActive(true);
        StartCoroutine(SureTimerRoutine());

    }
    IEnumerator SureTimerRoutine()
    {
        while (sureSaysinmi)
        {
            yield return new WaitForSeconds(1f);

            if (RakamPanelTimer == 3)
            {
                RakkamPanel.SetActive(true);
                SonucYazdir();
                Ball.SetActive(false);
            }
            if (RakamPanelTimer <= 0)
            {
                {
                    //Ball.SetActive(true);
#pragma warning disable CS0618 // Tür veya üye artık kullanılmıyor
                    Application.LoadLevel("Game");
#pragma warning restore CS0618 // Tür veya üye artık kullanılmıyor
                }
            }
            RakamPanelTimer--;
        }
    }
    void SonucYazdir()
    {
        int rd = Random.Range(0, 36);
        PlayerPrefs.SetInt("Roulette", rd);
        RouletteSonucText.text = rd.ToString();
        if(rd == 0)
        {
            Green.SetActive(true);
        }
        else if(rd ==1 || rd ==3 || rd ==5 || rd ==7 || rd ==9 || rd ==12 || rd ==14 || rd ==16 || rd ==18 || rd ==19 || rd ==21 || rd ==23 || rd ==25 || rd ==27 || rd ==30 || rd ==32 || rd ==34 || rd ==36)
        {
            Red.SetActive(true);
        }
        else
        {
            Black.SetActive(true);
        }
    }

}
