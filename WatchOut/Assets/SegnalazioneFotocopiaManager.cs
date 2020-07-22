using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SegnalazioneFotocopiaManager : MonoBehaviour
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
    public void tornaIndietro()
    {
        SceneManager.LoadScene("Analisi_Simec", LoadSceneMode.Single);

    }
    public void check3()
    {

        x3.SetActive(!x3.activeSelf);
    }

    public void inviaSegnalazione()
    {
        Analisi_Simec_Manager.cl1 = true;
        
        Analisi_Simec_Manager.fotocopiaS += -75; Analisi_Simec_Manager.fotocopiaR += -60; 
       

        SceneManager.LoadScene("Analisi_Simec", LoadSceneMode.Single);

    }
    private void Start()
    {

        Text t1 = (Text)GameObject.Find("soldi").GetComponent("Text");
        Text t2 = (Text)GameObject.Find("reputazione").GetComponent("Text");
        t1.text = System.Convert.ToString(HomeManager.soldi);
        t2.text = System.Convert.ToString(HomeManager.reputazione);
    }
}
