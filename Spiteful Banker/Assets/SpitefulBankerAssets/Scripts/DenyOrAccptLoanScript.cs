using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DenyOrAccptLoanScript : MonoBehaviour
{
    public TextMeshProUGUI chaosText;

    public float chaosPoints;

    public float pointsAdded = 10;
    public float pointsTaken = 20;

    public void Start()
    {
        chaosPoints = 0;
        UpdateChaosText();
    }

    public void AcceptLoan()
    {
        if(gameObject.GetComponent<RandomGenorationPaperwork>().paperworkIsWrong == true)
        {
            chaosPoints += pointsAdded;

            UpdateChaosText();

            gameObject.GetComponent<RandomGenorationPaperwork>().isTalking = false;
        }

        if (gameObject.GetComponent<RandomGenorationPaperwork>().paperworkIsWrong == false)
        {
            chaosPoints -= pointsTaken;

            UpdateChaosText();
            gameObject.GetComponent<RandomGenorationPaperwork>().isTalking = false;
        }

    }

    public void DennyLoan()
    {
        if (gameObject.GetComponent<RandomGenorationPaperwork>().paperworkIsWrong == true)
        {
            chaosPoints -= pointsTaken;

            UpdateChaosText();
            gameObject.GetComponent<RandomGenorationPaperwork>().isTalking = false;
        }

        if (gameObject.GetComponent<RandomGenorationPaperwork>().paperworkIsWrong == false)
        {
            chaosPoints += pointsAdded;

            UpdateChaosText();
            gameObject.GetComponent<RandomGenorationPaperwork>().isTalking = false;
        }

    }

    public void UpdateChaosText()
    {
        chaosText.text = chaosPoints.ToString();

    }
}
