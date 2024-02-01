using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gen : MonoBehaviour
{

    public bool creditGen = false;
    public static float creditInc = 0;
    public float increaseClock;

    public GameObject creditsPerSec;

    
    void Update()
    {
        creditInc = Stormtrooper.cps + Recon.cps + Commander.cps + Speeder.cps
            +ATST.cps + ATAT.cps + TieFighter.cps + TieInterceptor.cps + StarDestroyer.cps + DeathStar.cps;
        creditsPerSec.GetComponent<Text>().text = "" + Mathf.Round(creditInc * 100f) / 100f;
        increaseClock = creditInc;
        if (creditGen == false) {
            creditGen = true;
            StartCoroutine(GenCredits());
        }
    }
    IEnumerator GenCredits() {
        Credits.creditCounter += increaseClock;
        yield return new WaitForSeconds(1);
        creditGen = false;
    }
}
