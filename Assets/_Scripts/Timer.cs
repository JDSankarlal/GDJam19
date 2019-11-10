using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image bar;
    public float shotClockTime;

    public playerMovement pM;
    //private float shotClock;

    // Start is called before the first frame update
    void Start()
    {
        bar.GetComponent<Image>();
        //shotClock = shotClockTime;
    }

    // Update is called once per frame
    void Update()
    {
        //shotClock -= Time.deltaTime;

        //bar.fillAmount -= (shotClockTime / 100);
        bar.fillAmount -= Time.deltaTime / shotClockTime;

        if (pM.resetTime)
        {
            Debug.Log("hi");
            bar.fillAmount = 1;
            pM.resetTime = false;
        }

        if (bar.fillAmount <= 0.0f)
        {
            //Debug.Log("Game Over");
        }
    }
}
