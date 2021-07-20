using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenorationPaperwork : MonoBehaviour
{

    public GameObject[] characters;

    public GameObject paperworkOneGood;
    public GameObject paperworkTwoGood;
   

    public GameObject paperworkOneBad;
    public GameObject paperworkTwoBad;

    public Animator paperworkAnimation;
    public Animator characterAnimation;

    public string charecterAnimationTrigger;
    public string paperworkAnimationTrigger;

    public bool paperworkIsWrong;

    public bool isTalking;



    public void Start()
    {
        ResetPaperworkAndCharacters();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPaperworkAndCharacters()
    {
   
        foreach (GameObject Charecter in characters)
          {
             Charecter.SetActive(false);
             Debug.Log("RESET");

         }

        paperworkOneGood.SetActive(false);
        paperworkTwoGood.SetActive(false);
        paperworkOneBad.SetActive(false);
        paperworkTwoBad.SetActive(false);

    }

    public void Newcharacter()
    {
        isTalking = true;

        ResetPaperworkAndCharacters();

        int characterSelection = Random.Range(0, characters.Length);

        int paperworkOneSelection = Random.Range(0, 2);

        int paperworkTwoSelection = Random.Range(0, 2);

        if (paperworkOneSelection == 0 && paperworkTwoSelection == 0)
        {
            paperworkIsWrong = false;
            Debug.Log("everything is good");
        }

        if (paperworkOneSelection == 1 && paperworkTwoSelection == 0)
        {
            paperworkIsWrong = true;
            Debug.Log("everything is bad");
        }

        if (paperworkOneSelection == 0 && paperworkTwoSelection == 1)
        {
            paperworkIsWrong = true;
            Debug.Log("everything is bad");
        }

        if (paperworkOneSelection == 1 && paperworkTwoSelection == 1)
        {
            paperworkIsWrong = true;
            Debug.Log("everything is bad");
        }

        characters[characterSelection].SetActive(true);

        if (paperworkOneSelection == 0)
        {
            Debug.Log("paperworkOneGood");
            paperworkOneGood.SetActive(true);
        }

        if (paperworkOneSelection == 1)
        {
            Debug.Log("paperworkOneBad");
            paperworkOneBad.SetActive(true);

        }

        if (paperworkTwoSelection == 0)
        {
            Debug.Log("paperworkTwoGood");
            paperworkTwoGood.SetActive(true);
        }

        if (paperworkTwoSelection == 1)
        {
            Debug.Log("paperworkTwoBad");
            paperworkTwoBad.SetActive(true);
        }
        //characterAnimation.SetTrigger(charecterAnimationTrigger);
        paperworkAnimation.SetTrigger(paperworkAnimationTrigger);

        

    }
}
