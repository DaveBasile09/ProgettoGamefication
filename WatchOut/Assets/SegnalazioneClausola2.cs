using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

        if (x1.activeSelf) { AnalisiContrattiManager.cl2S += -15;AnalisiContrattiManager.cl2R += +30; }
        else { AnalisiContrattiManager.cl2S += -25; AnalisiContrattiManager.cl2R += -30; }
        if (x2.activeSelf) { AnalisiContrattiManager.cl2S += -25; AnalisiContrattiManager.cl2R += -30; }
        SceneManager.LoadScene("Analisi_Contratti", LoadSceneMode.Single);


    }
    private void Start()
    {

        Text t1 = (Text)GameObject.Find("soldi").GetComponent("Text");
        Text t2 = (Text)GameObject.Find("reputazione").GetComponent("Text");
        t1.text = System.Convert.ToString(HomeManager.soldi);
        t2.text = System.Convert.ToString(HomeManager.reputazione);
    }

}