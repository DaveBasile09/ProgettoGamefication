using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnalisiContrattiManager : MonoBehaviour
{
    public GameObject check1;
    public GameObject check2;
    public GameObject check3;
    
    
    public static bool cl1=false;
    public static bool cl2=false;
    public static bool cl3=false;

    public static int cl1S = 0;
    public static int cl1R = 0;
    public static int cl2S = 0;
    public static int cl2R = 0;
    public static int cl3S = 0;
    public static int cl3R = 0;

    public void indietro()
    {
    cl1 = false;
    cl2 = false;
    cl3 = false;

    cl1S = 0;
    cl1R = 0;
    cl2S = 0;
    cl2R = 0;
    cl3S = 0;
    cl3R = 0;
    ChiediOperatoreManager.indietro();
    }
    public void termina()


    {
        if (!cl1) { cl1S += 0;cl1R += 10; }
        if (!cl2) { cl2S += -40; cl2R += -60; }
        if (!cl3) { cl3S += 0; cl3R += 10; }


        ChiediOperatoreManager.c1 = true;
        HomeManager.controllo6 = true;
        HomeManager.soldi += cl1S + cl2S + cl3S;
        HomeManager.reputazione += cl1R + cl2R + cl3R;
        EndgameManager.soldi[5]= cl1S + cl2S + cl3S;
        EndgameManager.reputazione[5]= cl1R + cl2R + cl3R;
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
            GameObject.Find("Segnala1").SetActive(false);
            GameObject.Find("NonSegnala1").SetActive(false);
        }
        
        if (cl2)
        { 
            check2.SetActive(true);
            GameObject.Find("Segnala2").SetActive(false);
            GameObject.Find("NonSegnala2").SetActive(false);
        }
        
        if (cl3)
        { 
            check3.SetActive(true);
            GameObject.Find("Segnala3").SetActive(false);
            GameObject.Find("NonSegnala3").SetActive(false);
        }
    }
}
