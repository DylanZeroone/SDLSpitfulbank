using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCamera : MonoBehaviour
{
    public GameObject cameraOne;
    public GameObject cameraTwo;
    public GameObject cameraThree;
    public GameObject cameraFour;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MainMenuBackground());
    }


    public IEnumerator MainMenuBackground()
    {
        cameraOne.SetActive(true);
        cameraThree.SetActive(false);

        yield return new WaitForSeconds(4);

        cameraFour.SetActive(true);
        cameraOne.SetActive(false);

        yield return new WaitForSeconds(4);

        cameraTwo.SetActive(true);
        cameraFour.SetActive(false);

        yield return new WaitForSeconds(4);

        cameraThree.SetActive(true);
        cameraTwo.SetActive(false);

        yield return new WaitForSeconds(4);

        StartCoroutine(MainMenuBackground());

    }

}
