using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class change_to_start: MonoBehaviour
{
    float time=0;
    public void SceneChange()
    {
        SceneManager.LoadScene("1. start");
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 300f)
        {
            SceneManager.LoadScene("1. start");
        }


    }
}
