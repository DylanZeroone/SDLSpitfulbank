using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    public string positiveScoreScene;
    public string negetiveScoreScene;
    public string zeroScoreScene;

    public void EndOfGame()
    {

        PlayerPrefs.SetFloat("players_Score", gameObject.GetComponent<DenyOrAccptLoanScript>().chaosPoints);

        if (gameObject.GetComponent<DenyOrAccptLoanScript>().chaosPoints > 0)
        {
            
            SceneManager.LoadScene(positiveScoreScene);

        }

        if (gameObject.GetComponent<DenyOrAccptLoanScript>().chaosPoints == 0)
        {
            SceneManager.LoadScene(zeroScoreScene);

        }

        if (gameObject.GetComponent<DenyOrAccptLoanScript>().chaosPoints < 0)
        {
            SceneManager.LoadScene(negetiveScoreScene);

        }
    }

}
