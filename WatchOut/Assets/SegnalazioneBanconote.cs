using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SegnalazioneBanconote : MonoBehaviour
{
    public GameObject x1;
    public GameObject x2;
    public GameObject x3;




    public void check1()
    {


        x1.SetActive(!x1.activeSelf);

    }
    public void check2()
    {

        x2.SetActive(!x2.activeSelf);
    }
    public void check3()
    {

        x3.SetActive(!x3.activeSelf);
    }
    public void tornaIndietro()
    {
        SceneManager.LoadScene("Analisi_normativa_interna", LoadSceneMode.Single);

    }

    public void inviaSegnalazione()
    {
        AnalisiNormativa.cl3 = true;
        SceneManager.LoadScene("Analisi_normativa_interna", LoadSceneMode.Single);

    }
}
