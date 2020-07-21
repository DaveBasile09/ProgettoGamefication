using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnalisiNormativa : MonoBehaviour
   
{
public GameObject tablet;
    public static bool cl1 = false;
    public static bool cl2 = false;
    public static bool cl3 = false;

    public void indietro()
    {

        ChiediOperatoreManager.indietro();
    }
    public void termina()
    {
        ChiediOperatoreManager.c3 = true;
        HomeManager.controllo5 = true;
        ChiediOperatoreManager.termina();
    }
    public void clausola1()
    {
        if (!cl1)
        {
            SceneManager.LoadScene("Check_istruzioni_macchine", LoadSceneMode.Single);
        }
    }
    public void clausola2()
    {
        if (!cl2)
        {
            SceneManager.LoadScene("SegnalazioneNormativaCaricamentoBancomat", LoadSceneMode.Single);
        }

    }
    public void clausola3()
    {
        if (!cl3)
        {
            SceneManager.LoadScene("SegnalazioneNormativaBanconote", LoadSceneMode.Single);
        }

    }
}
