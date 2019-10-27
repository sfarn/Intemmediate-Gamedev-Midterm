using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {Debug.Log("uwu");
            if (SceneManager.GetSceneByName("Start Screen").Equals(SceneManager.GetActiveScene()))
                 {
                     Debug.Log("owo");
                     SceneManager.LoadScene(1);
                 }

            if (SceneManager.GetSceneByName("youwin").Equals(SceneManager.GetActiveScene()))
                             {
                                 Debug.Log("owo");
                                 SceneManager.LoadScene(0);
                             }
        }
        

    }
}
