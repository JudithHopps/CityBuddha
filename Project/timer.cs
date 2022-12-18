/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text ProgressIndicator;

    float currentValue;
    public float speed;


    // Update is called once per frame
    void Update()
    {
        if (currentValue < 100)
        {
            currentValue += speed * Time.deltaTime;
            timer_ui= ((int)currentValue).ToString() + "%";
        }
        else
        {
            timer_ui = "Done";
            currentValue -= 100;
        }


    }
}*/