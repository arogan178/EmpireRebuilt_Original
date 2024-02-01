using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomEvent : MonoBehaviour
{
    public GameObject stats;
    public float creditCheck;
    public int eventChance;
    public bool randomEventsOn = false;
    public int creditLost;

    void Update()
    {
        creditCheck = Credits.creditCounter / 100;
        if (randomEventsOn == false) {
            StartCoroutine(StartRandomEvents());
        }
    }
    IEnumerator StartRandomEvents() {
        randomEventsOn = true;
        eventChance = Random.Range(1, 20);
        if(creditCheck >= eventChance) {
            creditLost = Mathf.RoundToInt(Credits.creditCounter * (Random.Range(0.0f, 0.4f)));
            stats.GetComponent<Text>().text = "Trade Routes Seized by Rebel Forces! \n" + creditLost + " Credits Lost ";
            Credits.creditCounter -= creditLost;
            yield return new WaitForSeconds(3);
            stats.GetComponent<Animation>().Play("events");
            yield return new WaitForSeconds(1);
            stats.SetActive(false);
            stats.SetActive(true);

        }
        yield return new WaitForSeconds(Random.Range(10, 60));
        randomEventsOn = false;
    }
}
