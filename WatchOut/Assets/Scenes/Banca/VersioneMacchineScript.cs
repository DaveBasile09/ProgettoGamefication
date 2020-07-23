using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VersioneMacchineScript : MonoBehaviour
{

    public GameObject x1;
    public GameObject x2;
    public GameObject x3;
    public GameObject x4;
    public GameObject x5;
    public GameObject x6;

    private void Start()
    {

        Text t1 = (Text)GameObject.Find("soldi").GetComponent("Text");
        Text t2 = (Text)GameObject.Find("reputazione").GetComponent("Text");
        t1.text = System.Convert.ToString(HomeManager.soldi);
        t2.text = System.Convert.ToString(HomeManager.reputazione);
    }
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

        if(x1.activeSelf)
        {
            BancaManager.PuntiVersioneMacchineEconomico -= 60;
            BancaManager.PuntiVersioneMacchineReputazione -= 40;
        }
        
        if(x2.activeSelf)
        {
            BancaManager.PuntiVersioneMacchineEconomico -= 15;
            BancaManager.PuntiVersioneMacchineReputazione += 40;
        }
        else
        {
            BancaManager.PuntiVersioneMacchineEconomico -= 60;
            BancaManager.PuntiVersioneMacchineReputazione -= 40;
        }

        if(x3.activeSelf)
        {
            BancaManager.PuntiVersioneMacchineEconomico -= 60;
            BancaManager.PuntiVersioneMacchineReputazione -= 40;
        }

        if (x4.activeSelf)
        {
            BancaManager.PuntiVersioneMacchineEconomico -= 15;
            BancaManager.PuntiVersioneMacchineReputazione += 40;
        }
        else
        {
            BancaManager.PuntiVersioneMacchineEconomico -= 60;
            BancaManager.PuntiVersioneMacchineReputazione -= 40;
        }
        
        if (x5.activeSelf)
        {
            BancaManager.PuntiVersioneMacchineEconomico -= 15;
            BancaManager.PuntiVersioneMacchineReputazione += 40;
        }
        else
        {
            BancaManager.PuntiVersioneMacchineEconomico -= 60;
            BancaManager.PuntiVersioneMacchineReputazione -= 40;
        }
        
        if (x6.activeSelf)
        {
            BancaManager.PuntiVersioneMacchineEconomico -= 60;
            BancaManager.PuntiVersioneMacchineReputazione -= 40;
        }
        
        





            BancaManager.terminaSegnalazioneVersioneMacchine();
    }
}
