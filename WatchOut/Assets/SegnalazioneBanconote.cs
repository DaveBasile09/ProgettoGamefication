using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

        if (x1.activeSelf) { AnalisiNormativa.normativaBanconoteS += -10; AnalisiNormativa.normativaBanconoteR += 20; }
        else { AnalisiNormativa.normativaBanconoteS += -30; AnalisiNormativa.normativaBanconoteR += -20; }
        if (x2.activeSelf) { AnalisiNormativa.normativaBanconoteS += -10; AnalisiNormativa.normativaBanconoteR += 20; }
        else { AnalisiNormativa.normativaBanconoteS += -30; AnalisiNormativa.normativaBanconoteR += -20; }
        if (x3.activeSelf) { Analisi_Simec_Manager.fotocopiaS += -30; Analisi_Simec_Manager.fotocopiaR += -20; }
        AnalisiNormativa.cl3 = true;
        SceneManager.LoadScene("Analisi_normativa_interna", LoadSceneMode.Single);

    }
    private void Start()
    {

        Text t1 = (Text)GameObject.Find("soldi").GetComponent("Text");
        Text t2 = (Text)GameObject.Find("reputazione").GetComponent("Text");
        t1.text = System.Convert.ToString(HomeManager.soldi);
        t2.text = System.Convert.ToString(HomeManager.reputazione);
    }
}
