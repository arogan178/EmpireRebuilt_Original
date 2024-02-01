using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyLog : MonoBehaviour
{
    public GameObject AutoGen;
    public float multiplier = 1.15f;

    public float Truncate(float value) {
        float price = value;
        price = Mathf.Round(price * 10f) / 10f;
        return price;
    }
    public void StartStormtrooper() {

        //Stormtrooper

        Credits.creditCounter -= Stormtrooper.stormtrooperValue;
        Stormtrooper.elementCounter++;
        Stormtrooper.stormtrooperValue = Truncate(Stormtrooper.basePrice * Mathf.Pow(multiplier, Stormtrooper.elementCounter));
        Stormtrooper.disableButton = true;
        Stormtrooper.cps += 0.1f;
    }

    public void StartRecon() {
        
        //Recon
        Credits.creditCounter -= Recon.reconValue;
        Recon.elementCounter++;
        Recon.reconValue = Truncate(Recon.basePrice * Mathf.Pow(multiplier, Recon.elementCounter));
        Recon.disableButton = true;
        Recon.cps += 0.3f;

    }
    public void StartCommander()
    {
        
        //Commander
        Credits.creditCounter -= Commander.commanderValue;
        Commander.elementCounter++;
        Commander.commanderValue = Truncate(Commander.basePrice * Mathf.Pow(multiplier, Commander.elementCounter));
        Commander.disableButton = true;
        Commander.cps += 1;

        
    }

    public void StartSpeeder() {
        
        //Speeder
        Credits.creditCounter -= Speeder.speederValue;
        Speeder.elementCounter++;
        Speeder.speederValue = Truncate(Speeder.basePrice * Mathf.Pow(multiplier, Speeder.elementCounter));
        Speeder.disableButton = true;
        Speeder.cps += 3.1f;
    }

    public void StartATST() {
        
        //ATST
        Credits.creditCounter -= ATST.atstValue;
        ATST.elementCounter++;
        ATST.atstValue = Truncate(ATST.basePrice * Mathf.Pow(multiplier, ATST.elementCounter));
        ATST.disableButton = true;
        ATST.cps += 6;
    }
    public void StartATAT() {
        
        //ATAT
        Credits.creditCounter -= ATAT.atatValue;
        ATAT.elementCounter++;
        ATAT.atatValue = Truncate(ATAT.basePrice * Mathf.Pow(multiplier, ATAT.elementCounter));
        ATAT.disableButton = true;
        ATAT.cps += 20;
    }
    public void StartTieFighter() {
        
        //TieFighter
        Credits.creditCounter -= TieFighter.tiefighterValue;
        TieFighter.elementCounter++;
        TieFighter.tiefighterValue = Truncate(TieFighter.basePrice * Mathf.Pow(multiplier, TieFighter.elementCounter));
        TieFighter.disableButton = true;
        TieFighter.cps += 40;

    }
    public void StartTieInterceptor() {
        
        //TieInterceptor
        Credits.creditCounter -= TieInterceptor.tieinterceptorValue;
        TieInterceptor.elementCounter++;
        TieInterceptor.tieinterceptorValue = Truncate(TieInterceptor.basePrice * Mathf.Pow(multiplier, TieInterceptor.elementCounter));
        TieInterceptor.disableButton = true;
        TieInterceptor.cps += 70;
    }
    public void StartStarDestroyer() {
        
        //StarDestroyer
        Credits.creditCounter -= StarDestroyer.stardestroyerValue;
        StarDestroyer.elementCounter++;
        StarDestroyer.stardestroyerValue = Truncate(StarDestroyer.basePrice * Mathf.Pow(multiplier, StarDestroyer.elementCounter));
        StarDestroyer.disableButton = true;
        StarDestroyer.cps += 300;
    }
    public void StartDeathStart()
    {
        
        //DeathStar
        Credits.creditCounter -= DeathStar.deathstarValue;
        DeathStar.elementCounter++;
        DeathStar.deathstarValue = Truncate(DeathStar.basePrice * Mathf.Pow(multiplier, DeathStar.elementCounter));
        DeathStar.disableButton = true;
        DeathStar.cps += 1500;
    }

    }
