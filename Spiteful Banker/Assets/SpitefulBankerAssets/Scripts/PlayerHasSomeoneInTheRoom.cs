using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHasSomeoneInTheRoom : MonoBehaviour
{


    public GameObject doorButton;
    public GameObject acceptButton;
    public GameObject dennyButton;

    public void TalkingToSomeone()
    {
        if (gameObject.GetComponent<RandomGenorationPaperwork>().isTalking == true)
        {
            doorButton.SetActive(false);
            acceptButton.SetActive(true);
            dennyButton.SetActive(true);

        }

        if (gameObject.GetComponent<RandomGenorationPaperwork>().isTalking == false)
        {
            doorButton.SetActive(true);
            acceptButton.SetActive(false);
            dennyButton.SetActive(false);

            gameObject.GetComponent<RandomGenorationPaperwork>().ResetPaperworkAndCharacters();

        }

    }
    


}
