using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChiediOperatoreManager : MonoBehaviour

{   
    public static bool c1 =false;
    public static bool c2=false;
    public static bool c3=false;
    private void Start()
    {
        Text t1 = (Text)GameObject.Find("soldi").GetComponent("Text");
        Text t2 = (Text)GameObject.Find("reputazione").GetComponent("Text");
        t1.text = System.Convert.ToString(HomeManager.soldi);
        t2.text = System.Convert.ToString(HomeManager.reputazione);
    }
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
            SceneManager.LoadScene("Analisi_Simec", LoadSceneMode.Single);
        }
    }

    public void avvia3()
    {
        if (!c3)
        {
            SceneManager.LoadScene("Analisi_normativa_interna", LoadSceneMode.Single);
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
    public void tornaCheck()
    {
        SceneManager.LoadScene("HomeBanca", LoadSceneMode.Single);
    }
}
