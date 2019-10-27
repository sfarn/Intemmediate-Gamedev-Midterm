using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //start game from start screen
            if (SceneManager.GetSceneByName("Start Screen").Equals(SceneManager.GetActiveScene()))
                 {
                     SceneManager.LoadScene(1);
                 }
            
            //restart game from endscreen
            if (SceneManager.GetSceneByName("youwin").Equals(SceneManager.GetActiveScene()))
                             {
                                 SceneManager.LoadScene(0);
                             }
        }
    }
}
