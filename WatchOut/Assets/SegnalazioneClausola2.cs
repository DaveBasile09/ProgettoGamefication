using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SegnalazioneClausola2 : MonoBehaviour
{

    public GameObject x1;
    public GameObject x2;



    public void check1()
    {


        x1.SetActive(!x1.activeSelf);

    }
    public void check2()
    {

        x2.SetActive(!x2.activeSelf);
    }
    public void tornaIndietro()
    {
        SceneManager.LoadScene("Analisi_Contratti", LoadSceneMode.Single);

    }

    public void inviaSegnalazione()
    {
        AnalisiContrattiManager.cl2 = true;
        SceneManager.LoadScene("Analisi_Contratti", LoadSceneMode.Single);

    }
}