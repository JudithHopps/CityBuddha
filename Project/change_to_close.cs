using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class change_to_close: MonoBehaviour
{
    float time=0;
    int i = 1;
    public void SceneChange()
    {
        SceneManager.LoadScene("4. close");
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
       
        if (time >2f) 
        {
            i += 1;
            time = 0;
            
        }
        if ( i == 72) //170초후 자동 씬 전환
        {
            SceneManager.LoadScene("4. close");
        }

    }
}
