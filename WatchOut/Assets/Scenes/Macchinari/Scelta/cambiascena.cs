using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cambiascena : MonoBehaviour
{

    public static bool Ido=false;
    public static bool aut=false;
    void Start()
    {
        Text t1 = (Text)GameObject.Find("soldi").GetComponent("Text");
        Text t2 = (Text)GameObject.Find("reputazione").GetComponent("Text");
        t1.text = System.Convert.ToString(HomeManager.soldi);
        t2.text = System.Convert.ToString(HomeManager.reputazione);
        if (HomeManager.soldi <= 0 || HomeManager.reputazione<=0)
        {
            //vai al resoconto
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

   
}
