using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image bar;
    public float shotClockTime;
    //private float shotClock;
    public Gift gift;

    // Start is called before the first frame update
    void Start()
    {
        bar.GetComponent<Image>();
        //shotClock = shotClockTime;
        gift.GetComponent<Gift>();
    }

    // Update is called once per frame
    void Update()
    {
        //shotClock -= Time.deltaTime;

        //bar.fillAmount -= (shotClockTime / 100);
        bar.fillAmount -= Time.deltaTime / shotClockTime;

        //Debug.Log(bar.fillAmount);
        //Debug.Log(shotClock);

        if(gift.resetTimer)
        {
            bar.fillAmount = 1;
            gift.resetTimer = false;
        }

        if (bar.fillAmount <= 0.0f)
        {
            //Debug.Log("Game Over");
        }
    }

}
