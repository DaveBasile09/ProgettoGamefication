using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Analisi_Simec_Manager : MonoBehaviour
{
    public GameObject check1;
    public GameObject check2;
    public GameObject segnala1;
    public GameObject segnala2;
    public GameObject nonSegnala1;
    public GameObject nonSegnala2;
    

    public static bool cl1 = false;
    public static bool cl2 = false;
    public static int fotocopiaS=0;
    public static int fotocopiaR=0;
    public static int banconotaS=0;
    public static int banconotaR=0;



    public void indietro()
    {
     cl1 = false;
     cl2 = false;
     fotocopiaS = 0;
     fotocopiaR = 0;
     banconotaS = 0;
     banconotaR = 0;
    ChiediOperatoreManager.indietro();
    }
    public void termina()
    {

        ChiediOperatoreManager.c2 = true;
        HomeManager.controllo4 = true;
        if(!cl1) { nonSegnalareClausola1(); }
        if (!cl2) { nonSegnalareClausola2(); }
        HomeManager.soldi += fotocopiaS + banconotaS;
        HomeManager.reputazione+= fotocopiaR + banconotaR;
        EndgameManager.soldi[3]= fotocopiaS + banconotaS;
        EndgameManager.reputazione[3] = fotocopiaR + banconotaR;
        ChiediOperatoreManager.termina();
    }
    public void clausola1()
    {
        if (!cl1)
        {
            SceneManager.LoadScene("SegnalazionePresenzaFotocopia", LoadSceneMode.Single);
        }
    }
    
    public void nonSegnalareClausola1()
    {
        cl1 = true;
        banconotaS += 0;
        banconotaR += 15;
    }
    public void clausola2()
    {
        if (!cl2)
        {
            SceneManager.LoadScene("SegnalazionePresenzaDocumento", LoadSceneMode.Single);
        }

    }
    
    public void nonSegnalareClausola2()
    {
        cl2 = true;
        fotocopiaS += -20;
        fotocopiaR += -40;
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
    }
}
