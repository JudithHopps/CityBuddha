using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class change_to_main: MonoBehaviour
{
    float time=0;
    public void SceneChange()
    {
        SceneManager.LoadScene("3. main");
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 3.5f) //4�� �� main ������ �̵�
        {
            SceneManager.LoadScene("3. main");
        }


    }
}
