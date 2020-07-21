﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnalisiContrattiManager : MonoBehaviour
{
    public static bool cl1=false;
    public static bool cl2=false;
    public static bool cl3=false;

    public void indietro()
    {
       
        ChiediOperatoreManager.indietro();
    }
    public void termina()
    {
        ChiediOperatoreManager.c1 = true;
        HomeManager.controllo6 = true;
        ChiediOperatoreManager.termina();
    }
    public void clausola1()
    {
        if (!cl1)
        {
            SceneManager.LoadScene("SegnalazionePresenzaClausola1", LoadSceneMode.Single);
        }
    }
    public void clausola2()
    {
        if (!cl2)
        {
            SceneManager.LoadScene("SegnalazionePresenzaClausola2", LoadSceneMode.Single);
        }

    }
    public void clausola3()
    {
        if (!cl3)
        {
            SceneManager.LoadScene("SegnalazionePresenzaContratto", LoadSceneMode.Single);
        }

    }
}
