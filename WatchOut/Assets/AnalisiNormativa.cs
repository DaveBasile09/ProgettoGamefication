using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnalisiNormativa : MonoBehaviour
   
{
public GameObject tablet;
public GameObject check1;
public GameObject check2;
public GameObject check3;
public GameObject segnala1;
public GameObject segnala2;
public GameObject segnala3;
public GameObject nonSegnala1;
public GameObject nonSegnala2;
public GameObject nonSegnala3;

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
    normativaBancomatR = 0;
    
    normativaBanconoteS = 0;
    normativaBanconoteR = 0;
    ChiediOperatoreManager.indietro();
    }
    public void termina()
    {
        ChiediOperatoreManager.c3 = true;
        HomeManager.controllo5 = true;
        if (!cl1) { nonSegnalareClausola1();}
        if (!cl2) { nonSegnalareClausola2();}
        if (!cl3) { nonSegnalareClausola3();}
        
        HomeManager.soldi += presenzaNormativaS + normativaBancomatS + normativaBanconoteS;
        EndgameManager.soldi[4] = presenzaNormativaS + normativaBancomatS + normativaBanconoteS;
        HomeManager.reputazione += presenzaNormativaR + normativaBancomatR + normativaBanconoteR;
        EndgameManager.reputazione[4] = presenzaNormativaR + normativaBancomatR + normativaBanconoteR;

        ChiediOperatoreManager.termina();
    }
    public void clausola1()
    {
        if (!cl1)
        {
            SceneManager.LoadScene("Check_istruzioni_macchine", LoadSceneMode.Single);
        }
    }
    
    public void nonSegnalareClausola1()
    {
        cl1 = true;
        presenzaNormativaS += 0;
        presenzaNormativaR += 20;
    }
    
    public void clausola2()
    {
        if (!cl2)
        {
            SceneManager.LoadScene("SegnalazioneNormativaCaricamentoBancomat", LoadSceneMode.Single);
        }

    }
    public void nonSegnalareClausola2()
    {
        cl2 = true;
        normativaBancomatS += 0; 
        normativaBancomatR += 20;
    }
    
    public void clausola3()
    {
        if (!cl3)
        {
            SceneManager.LoadScene("SegnalazioneNormativaBanconote", LoadSceneMode.Single);
        }

    }
    public void nonSegnalareClausola3()
    {
        cl3 = true;
        normativaBanconoteS -= 10; 
        normativaBanconoteR -= 20;
    }
    
    private void Start()
    {

        Text t1 = (Text)GameObject.Find("soldi").GetComponent("Text");
        Text t2 = (Text)GameObject.Find("reputazione").GetComponent("Text");
        t1.text = System.Convert.ToString(HomeManager.soldi);
        t2.text = System.Convert.ToString(HomeManager.reputazione);
    }
    
    public void Update()
    {
        if (cl1)
        {
            check1.SetActive(true);
            segnala1.gameObject.SetActive(false);
            nonSegnala1.gameObject.SetActive(false);
        }
        
        if (cl2)
        { 
            check2.SetActive(true);
            segnala2.gameObject.SetActive(false);
            nonSegnala2.gameObject.SetActive(false);
        }
        
        if (cl3)
        { 
            check3.SetActive(true);
            segnala3.gameObject.SetActive(false);
            nonSegnala3.gameObject.SetActive(false);
        }
    }
}
