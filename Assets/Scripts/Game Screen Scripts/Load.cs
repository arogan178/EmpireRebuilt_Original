using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    public float credits;
    public float cps;
    public int stormtrooper;
    public int recon;
    public int commander;
    public int speeder;
    public int atst;
    public int atat;
    public int tFighter;
    public int tieInterceptor;
    public int starDestroyer;
    public int deathStar;

    void Start()
    {
        if (MainMenuButtons.loading == true) {

            Credits.creditCounter = PlayerPrefs.GetFloat("Credits");
            cps = PlayerPrefs.GetFloat("CPS");
            Gen.creditInc = cps;
            Stormtrooper.elementCounter = PlayerPrefs.GetInt("Stormtrooper");
            Recon.elementCounter = PlayerPrefs.GetInt("Recon");
            Commander.elementCounter = PlayerPrefs.GetInt("Commander");
            Speeder.elementCounter = PlayerPrefs.GetInt("Speeder");
            ATST.elementCounter = PlayerPrefs.GetInt("ATST");
            ATAT.elementCounter = PlayerPrefs.GetInt("ATAT");
            TieFighter.elementCounter = PlayerPrefs.GetInt("TieFighter");
            TieInterceptor.elementCounter = PlayerPrefs.GetInt("TieInterceptor");
            StarDestroyer.elementCounter = PlayerPrefs.GetInt("StarDestroyer");
            DeathStar.elementCounter = PlayerPrefs.GetInt("DeathStar");
        }
    }

    
}
