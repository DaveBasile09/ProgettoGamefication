using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Analisi_Simec_Manager : MonoBehaviour
{
    public static bool cl1 = false;
    public static bool cl2 = false;
    public static int fotocopiaS=0;
    public static int fotocopiaR=0;
    public static int banconotaS=0;
    public static int banconotaR=0;



    public void indietro()
    {

        ChiediOperatoreManager.indietro();
    }
    public void termina()
    {

        ChiediOperatoreManager.c2 = true;
        HomeManager.controllo4 = true;
        if(!cl1) { banconotaS += 0;banconotaR += 15; }
        if (!cl2) { fotocopiaS += -20; fotocopiaR += -40; }
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
    public void clausola2()
    {
        if (!cl2)
        {
            SceneManager.LoadScene("SegnalazionePresenzaDocumento", LoadSceneMode.Single);
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
