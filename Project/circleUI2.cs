using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleUI2 : MonoBehaviour
{
    float time,time2;

    // Update is called once per frame
    void Update()
    {       
            if (time <= 2f)
            {
               // transform.localScale = Vector3.one * (1 + time );
                transform.localScale = new Vector3(transform.localScale.x + 0.001f * time, transform.localScale.y + 0.001f * time, 0);
                time += Time.deltaTime;
            }

            else if (time < 4f)
            {
                time2 += Time.deltaTime;
                transform.localScale = new Vector3(transform.localScale.x - 0.001f * time2, transform.localScale.y - 0.001f * time2, 0);
                time += Time.deltaTime;
            }

            else
            {
                time = 0;
                time2 = 0;
            }

        }

    public void resetAnim()
    {
        time = 0;
        time2 = 0;
        transform.localScale = Vector3.one;
    }
}