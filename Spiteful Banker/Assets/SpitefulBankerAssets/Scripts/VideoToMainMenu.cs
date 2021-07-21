using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoToMainMenu : MonoBehaviour
{
    public float waitTime;
    public float waitShowText;
    public float waitHideText;

    public GameObject score;

    public string MainMenuName;

    public void Start()
    {
        StartCoroutine(EndingCutscene());
    }

    public IEnumerator EndingCutscene()
    {
        yield return new WaitForSeconds(waitShowText);

        score.SetActive(true);

        yield return new WaitForSeconds(waitHideText);

        score.SetActive(false);

        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(MainMenuName);

    }
}
