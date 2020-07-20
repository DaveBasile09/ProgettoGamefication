using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Analisi_Simec_Manager : MonoBehaviour
{
    public static bool cl1 = false;
    public static bool cl2 = false;
    

    public void indietro()
    {

        ChiediOperatoreManager.indietro();
    }
    public void termina()
    {
        ChiediOperatoreManager.c2 = true;
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
   
}
