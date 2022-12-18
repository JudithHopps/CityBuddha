using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class change_to_pose : MonoBehaviour
{
   
    public void SceneChange()
    {
        SceneManager.LoadScene("2. pose");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
