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
        }

        if (gameObject.GetComponent<RandomGenorationPaperwork>().paperworkIsWrong == false)
        {
            chaosPoints -= pointsAdded;

            UpdateChaosText();
        }

    }

    public void DennyLoan()
    {
        if (gameObject.GetComponent<RandomGenorationPaperwork>().paperworkIsWrong == true)
        {
            chaosPoints -= pointsAdded;

            UpdateChaosText();
        }

        if (gameObject.GetComponent<RandomGenorationPaperwork>().paperworkIsWrong == false)
        {
            chaosPoints += pointsAdded;

            UpdateChaosText();
        }

    }

    public void UpdateChaosText()
    {
        chaosText.text = chaosPoints.ToString();

    }
}
