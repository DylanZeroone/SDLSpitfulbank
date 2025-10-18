using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TransferScore : MonoBehaviour
{
    public TextMeshProUGUI cutsceneText;

    public float cutsceneScore;

    private void Start()
    {
        cutsceneScore = PlayerPrefs.GetFloat("players_Score");

        cutsceneText.text = cutsceneScore.ToString();
    }


}
