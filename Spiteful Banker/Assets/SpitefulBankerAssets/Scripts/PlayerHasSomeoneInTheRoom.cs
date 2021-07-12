using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHasSomeoneInTheRoom : MonoBehaviour
{


    public GameObject doorButton;

    public void TalkingToSomeone()
    {
        if (gameObject.GetComponent<RandomGenorationPaperwork>().isTalking == true)
        {
            doorButton.SetActive(false);

        }

        if (gameObject.GetComponent<RandomGenorationPaperwork>().isTalking == false)
        {
            doorButton.SetActive(true);

            gameObject.GetComponent<RandomGenorationPaperwork>().ResetPaperworkAndCharacters();

        }

    }
    


}
