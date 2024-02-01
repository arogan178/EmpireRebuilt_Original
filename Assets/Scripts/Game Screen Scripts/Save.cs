using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public GameObject saveBtn;

    public void SaveFunction() {
        PlayerPrefs.SetFloat("Credits", Credits.creditCounter);
        PlayerPrefs.SetFloat("CPS", Gen.creditInc);
        PlayerPrefs.SetInt("Stormtrooper", Stormtrooper.elementCounter);
        PlayerPrefs.SetInt("Recon", Recon.elementCounter);
        PlayerPrefs.SetInt("Commander", Commander.elementCounter);
        PlayerPrefs.SetInt("Speeder", Speeder.elementCounter);
        PlayerPrefs.SetInt("ATST", ATST.elementCounter);
        PlayerPrefs.SetInt("ATAT", ATAT.elementCounter);
        PlayerPrefs.SetInt("TieFighter", TieFighter.elementCounter);
        PlayerPrefs.SetInt("TieInterceptor", TieInterceptor.elementCounter);
        PlayerPrefs.SetInt("StarDestroyer", StarDestroyer.elementCounter);
        PlayerPrefs.SetInt("DeathStar", DeathStar.elementCounter);
    }
}
