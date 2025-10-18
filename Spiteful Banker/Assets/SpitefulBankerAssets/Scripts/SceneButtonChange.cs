using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonChange : MonoBehaviour
{
    
    public void LoadNewScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);

    }
}
