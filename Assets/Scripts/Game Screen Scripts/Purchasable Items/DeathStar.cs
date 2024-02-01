using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeathStar : MonoBehaviour
{
    public GameObject btnPlaceholder;
    public GameObject txtPlaceholder;
    public GameObject btnActual;
    public GameObject txtActual;
    public GameObject counter;
    public GameObject Acounter;

    public static float deathstarValue = 30000000;
    public static bool disableButton = false;
    public static int elementCounter;
    public static int cps;
    public static float basePrice = 300000;

    public float currentCredits;

    void Update()
    {
        currentCredits = Credits.creditCounter;
        txtPlaceholder.GetComponent<Text>().text = "" + deathstarValue.ToString("0.00") ;
        txtActual.GetComponent<Text>().text = ""+deathstarValue;
        counter.GetComponent<Text>().text = "" + elementCounter;
        Acounter.GetComponent<Text>().text = "" + elementCounter;

        if (currentCredits >= deathstarValue) {
            btnPlaceholder.SetActive(false);
            btnActual.SetActive(true);
        }

        if (disableButton == true) {
            btnActual.SetActive(false);
            btnPlaceholder.SetActive(true);
            disableButton = false;

        }

    }
}
