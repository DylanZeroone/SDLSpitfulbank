using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoToMainMenu : MonoBehaviour
{
    public float waitTime;

    public string MainMenuName;

    public void Start()
    {
        StartCoroutine(EndingCutscene());
    }

    public IEnumerator EndingCutscene()
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(MainMenuName);

    }
}
