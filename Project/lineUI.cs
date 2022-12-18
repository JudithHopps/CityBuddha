using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineUI : MonoBehaviour
{
    float time, time2;

    // Update is called once per frame
    void Update()
    {


        if (time <= 8.2f)
        {
            //  transform.localScale = Vector3.one * (1 + time);

            transform.localScale = new Vector3
                        (transform.localScale.x + 1f * Time.deltaTime,
                        transform.localScale.y, 0);
            time += Time.deltaTime;

        }

        else if (time < 8.3f)
        {
            time2 += Time.deltaTime;

            // transform.localScale = new Vector3(1f, 1f, 1f);

            // transform.localScale = Vector3.one * (3 - time2);
            transform.localScale = new Vector3
                      (0,
                      transform.localScale.y, 0);
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
        
    }
}