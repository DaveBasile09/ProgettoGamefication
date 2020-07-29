using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour

    
{
        public GameObject filiale1;
        public GameObject filiale2;
        public GameObject filiale3;
        public GameObject filiale4;
        public GameObject filiale5;
        public GameObject filiale6;
        public GameObject tablet;
        public GameObject avvia;
    public GameObject locazione;
    public GameObject difficoltà;
    public GameObject nomeFiliale;
    public GameObject nonDisp;
    public static string v1 = "0";
    public GameObject ban1;
    public GameObject forzaNapoli;
    public static bool b1 = false;

    // Start is called before the first frame update
    void Start()
    {
        
        Image i6 = filiale6.GetComponent<Image>();

        i6.color = new Color(0.4f,0.4f,0.4f,0.5f);
        Image i2 = filiale2.GetComponent<Image>();

        i2.color = new Color(0.4f, 0.4f, 0.4f, 0.5f);
        Image i3 = filiale3.GetComponent<Image>();

        i3.color = new Color(0.4f, 0.4f, 0.4f, 0.5f);
        Image i4 = filiale4.GetComponent<Image>();

        i4.color = new Color(0.4f, 0.4f, 0.4f, 0.5f);
        Image i5 = filiale5.GetComponent<Image>();

        i5.color = new Color(0.4f, 0.4f, 0.4f, 0.5f);
        ((Text)ban1.GetComponent("Text")).text = v1;
        ((Text)GameObject.Find("p").GetComponent("Text")).text = v1;
        if (b1)
        {
           
            ((Text)GameObject.Find("Valorecompletamento").GetComponent("Text")).text = "1/6";
            forzaNapoli.SetActive(true);

        }
    }
    public void VienieVai()
    {

        tablet.SetActive(true);
        avvia.SetActive(false);
        locazione.SetActive(false);
        nomeFiliale.SetActive(false);
        difficoltà.SetActive(false);
        nonDisp.SetActive(true);
        


    }

    public void Appari()
        {
        tablet.SetActive(true);
        tablet.SetActive(true);
        avvia.SetActive(true);
        locazione.SetActive(true);
        nomeFiliale.SetActive(true);
        difficoltà.SetActive(true);
        nonDisp.SetActive(false);

    }
    public void Avvia()
    {
        SceneManager.LoadScene("HomeBanca", LoadSceneMode.Single);
    }
}
