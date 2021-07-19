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
            Debug.Log("+");
        }

        if (gameObject.GetComponent<DenyOrAccptLoanScript>().chaosPoints == 0)
        {
            SceneManager.LoadScene(positiveScoreScene);
            Debug.Log("why");
        }

        if (gameObject.GetComponent<DenyOrAccptLoanScript>().chaosPoints < 0)
        {
            SceneManager.LoadScene(negetiveScoreScene);
            Debug.Log("-");
        }
    }

}
