﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BancaManager : MonoBehaviour
{
    /* GameObject */
    public GameObject popupTarm;
    public GameObject popupBpm;
    public GameObject popupSegnalazioni;


    /* Controllo per le segnalazioni già effettuate */
    public static bool datiFiliale = true;
    public static bool macchine = true;
    public static bool versioneMacchine = true;
    
    /* Punteggi per segnalazione */
    public static int PuntiDatiFilialeEconomico = 0;
    public static int PuntiDatiFilialeReputazione = 0;

    public static int PuntiMacchineEconomico = 0;
    public static int PuntiMacchineReputazione = 0;
    
    public static int PuntiVersioneMacchineEconomico = 0;
    public static int PuntiVersioneMacchineReputazione = 0;
    
    private void Start()
    {
        Text t1 = (Text)GameObject.Find("soldi").GetComponent("Text");
        Text t2 = (Text)GameObject.Find("reputazione").GetComponent("Text");
        t1.text = System.Convert.ToString(HomeManager.soldi);
        t2.text = System.Convert.ToString(HomeManager.reputazione);
    }



    public void segnalaDatiFiliale()
    {
        if(datiFiliale) UnityEngine.SceneManagement.SceneManager.LoadScene("SegnalaDatiFiliale",LoadSceneMode.Single);
    }

    public void nonSegnalareDatiFiliale()
    {
        PuntiDatiFilialeReputazione = 10;
        datiFiliale = false;
    }

    public void segnalaMacchine()
    {
        if(macchine) UnityEngine.SceneManagement.SceneManager.LoadScene("SegnalaMacchine", LoadSceneMode.Single);
    }
    public void nonSegnalareMacchine()
    {
        PuntiMacchineEconomico -= 20;
        PuntiMacchineReputazione -= 60;
        macchine = false;
    }

    public void segnalaVersioneMacchinari()
    {
        if (versioneMacchine) UnityEngine.SceneManagement.SceneManager.LoadScene("SegnalaVersioneMacchine", LoadSceneMode.Single);
    } 
    public void nonSegnalareVersioneMacchinari()
    {
        PuntiVersioneMacchineEconomico -= 80;
        PuntiVersioneMacchineReputazione -= 80;
        versioneMacchine = false;
    }
    

    public static void tornaIndietro()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Banca", LoadSceneMode.Single);
    }

    public static void terminaSegnalazioneDatiFiliale()
    {
        datiFiliale = false;
        tornaIndietro();
    }

    public static void terminaSegnalazioneMacchine()
    {
        macchine = false;
        tornaIndietro();
    }

    public static void terminaSegnalazioneVersioneMacchine()
    {
        versioneMacchine = false;
        tornaIndietro();
    }

    public void showBpm()
    {
        StartCoroutine( ShowAndHide(popupBpm, 2.5f) ); 
    }
    
    
    public void showTarm()
    {
        StartCoroutine( ShowAndHide(popupTarm, 2.5f) ); 
    }
    
    
    IEnumerator ShowAndHide( GameObject go, float delay )
    {
        go.SetActive(true);
        yield return new WaitForSeconds(delay);
        go.SetActive(false);
    }

    public void tornaAllaChecklist()
    {
        SceneManager.LoadScene("HomeBanca", LoadSceneMode.Single);
    }

    public void concludiVerifica()
    {
        if (!(datiFiliale || macchine || versioneMacchine))
        {
            int soldi = PuntiDatiFilialeEconomico + PuntiMacchineEconomico + PuntiVersioneMacchineEconomico;
            int reputazione = PuntiDatiFilialeReputazione + PuntiMacchineReputazione + PuntiVersioneMacchineReputazione;
            EndgameManager.soldi[0] = soldi;
            EndgameManager.reputazione[0] = reputazione;
            HomeManager.controllo1 = true;
            HomeManager.soldi += soldi;
            HomeManager.reputazione += reputazione;
            tornaAllaChecklist();
        }
        else
        {
            StartCoroutine( ShowAndHide(popupSegnalazioni, 2.5f) ); 
        }
    }

}
