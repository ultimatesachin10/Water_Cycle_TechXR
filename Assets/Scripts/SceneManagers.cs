using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagers : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            int previousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
            if (previousSceneIndex < 0)
            {
                previousSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
            }
            SceneManager.LoadScene(previousSceneIndex);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            if (nextSceneIndex >= SceneManager.sceneCountInBuildSettings)
            {
                nextSceneIndex = 0;
            }
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
