﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cambiascena : MonoBehaviour
{

    public static bool Ido=false;
    public static bool aut=false;
    private GameObject check1;
    private GameObject check2;
    
    
    void Start()
    {
        check1 = GameObject.Find("check1");
        check1.SetActive(false);
        check2 = GameObject.Find("check2");
        check2.SetActive(false);
        Text t1 = (Text)GameObject.Find("soldi").GetComponent("Text");
        Text t2 = (Text)GameObject.Find("reputazione").GetComponent("Text");
        t1.text = System.Convert.ToString(HomeManager.soldi);
        t2.text = System.Convert.ToString(HomeManager.reputazione);
        if (HomeManager.soldi <= 0 || HomeManager.reputazione<=0)
        {
            EndgameManager.gameOver = true;
            SceneManager.LoadScene("Endgame", LoadSceneMode.Single);
        }
        if (Ido)
        {
            GameObject.Find("Avvia1").SetActive(false);
            check1.SetActive(true);
        }
        if (aut)
        {
            GameObject.Find("Avvia2").SetActive(false);
            check2.SetActive(true);
        }
    }

   
        
    

   

    public void avviaIdo()
    {
        if (!Ido)
        {
            SceneManager.LoadScene("TestIdoneità", LoadSceneMode.Single);
        }
    }

    public void avviaAut()
    {
        if (!aut)
        {
            SceneManager.LoadScene("TestAutenticità", LoadSceneMode.Single);
        }
    }

    public void home()
    {
        SceneManager.LoadScene("Scenes/HomeBanca/HomeBanca", LoadSceneMode.Single);

    }
    public static void reset()
    {
        Ido = false;
    aut = false;
}

   
}
