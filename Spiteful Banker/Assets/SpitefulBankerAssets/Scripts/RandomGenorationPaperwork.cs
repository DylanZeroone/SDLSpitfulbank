using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenorationPaperwork : MonoBehaviour
{

    public GameObject[] characters;

    public GameObject paperworkOneGood;
    public GameObject paperworkTwoGood;
    public GameObject paperworkThreeGood;

    public GameObject paperworkOneBad;
    public GameObject paperworkTwoBad;

    public bool paperworkIsWrong;



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

    }

    public void Newcharacter()
    {
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

        }

        if (paperworkOneSelection == 1)
        {
            Debug.Log("paperworkOneBad");

        }

        if (paperworkTwoSelection == 0)
        {
            Debug.Log("paperworkTwoGood");

        }

        if (paperworkTwoSelection == 1)
        {
            Debug.Log("paperworkTwoBad");

        }


    }
}
