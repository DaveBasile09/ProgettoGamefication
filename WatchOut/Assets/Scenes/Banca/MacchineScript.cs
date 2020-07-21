﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MacchineScript : MonoBehaviour
{

    public GameObject x1;
    public GameObject x2;
    public GameObject x3;
    public GameObject x4;
    public GameObject x5;
    public GameObject x6;


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

    public void check4()
    {
        x4.SetActive(!x4.activeSelf);
    }

    public void check5()
    {
        x5.SetActive(!x5.activeSelf);
    }

    public void check6()
    {
        x6.SetActive(!x6.activeSelf);
    }

    public void tornaIndietro()
    {
        BancaManager.tornaIndietro();
    }

    public void terminaSegnalazione()
    {
        BancaManager.terminaSegnalazioneMacchine();
    }
}
