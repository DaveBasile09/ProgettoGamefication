using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChiediOperatoreManager : MonoBehaviour

{   
    public static bool c1 =false;
    public static bool c2=false;
    public static bool c3=false;
public void avvia1()
    {
        if (!c1)
        {
            SceneManager.LoadScene("Analisi_Contratti", LoadSceneMode.Single);
        }
    }
    public void avvia2()
    {
        if (!c2)
        {
            SceneManager.LoadScene("Analisi_Contratti", LoadSceneMode.Single);
        }
    }

    public static void indietro()
    {
        SceneManager.LoadScene("Chiedi_Operatore", LoadSceneMode.Single);
    }
    public static void termina()
    {
        SceneManager.LoadScene("Chiedi_Operatore", LoadSceneMode.Single);
    }
}
