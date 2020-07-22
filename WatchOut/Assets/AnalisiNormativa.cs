using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnalisiNormativa : MonoBehaviour
   
{
public GameObject tablet;
    public static bool cl1 = false;
    public static bool cl2 = false;
    public static bool cl3 = false;
    public static int presenzaNormativaS = 0;
    public static int presenzaNormativaR = 0;
    public static int normativaBancomatS = 0;
    public static int normativaBanconoteR=0;
    public static int normativaBancomatR = 0;
    public static int normativaBanconoteS = 0;


    public void indietro()
    {
     cl1 = false;
    cl2 = false;
    cl3 = false;
    presenzaNormativaS = 0;
     presenzaNormativaR = 0;
    normativaBancomatS = 0;
    normativaBanconoteR = 0;
     normativaBancomatR = 0;
     normativaBanconoteS = 0;
    ChiediOperatoreManager.indietro();
    }
    public void termina()
    {
        ChiediOperatoreManager.c3 = true;
        HomeManager.controllo5 = true;
        if (!cl1) { presenzaNormativaS += 0; presenzaNormativaR += 20;}
        if (!cl2) { normativaBancomatS += 0; normativaBancomatR += 20;}
        HomeManager.soldi += presenzaNormativaS + normativaBancomatS + normativaBanconoteS;
        HomeManager.reputazione += presenzaNormativaR + normativaBancomatR + normativaBanconoteR;

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
    private void Start()
    {

        Text t1 = (Text)GameObject.Find("soldi").GetComponent("Text");
        Text t2 = (Text)GameObject.Find("reputazione").GetComponent("Text");
        t1.text = System.Convert.ToString(HomeManager.soldi);
        t2.text = System.Convert.ToString(HomeManager.reputazione);
    }
}
