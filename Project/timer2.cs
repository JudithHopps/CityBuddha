/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public Text timer;
    public float time = 9f;
    private float selectCountdown;

    // Start is called before the first frame update
    void Start()
    {
        selectCountdown = time;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Floor(selectCountdown) > 0)
        { selectCountdown -= time.deltaTime;
            timer.text = Mathf.Floor(selectCountdown).ToString(); }
    }
}*/
