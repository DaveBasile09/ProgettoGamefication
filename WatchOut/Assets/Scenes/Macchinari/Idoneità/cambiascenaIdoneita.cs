using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cambiascenaIdoneita : MonoBehaviour
{
   
    public static bool A=false;
    public static bool B=false;
    public static bool C=false;
    public static bool D=false;
    public static string ultimo;
    public static Dictionary<string, HashSet<int>> risIdo = new Dictionary<string, HashSet<int>>();
    private  int parzialeSoldi=0;
    private  int parzialeReputazione=0;
    private GameObject c1;
    private GameObject c2;
    private GameObject c3;
    private GameObject c4;


    void Start()
    {
        c1= GameObject.Find("check1");
        c1.SetActive(false);
        c2= GameObject.Find("check2");
        c2.SetActive(false);
        c3= GameObject.Find("check3");
        c3.SetActive(false);
        c4= GameObject.Find("check4");
        c4.SetActive(false);
        
        if (A)
            togliA();
        if (B)
            togliB();
        if (C)
            togliC();
        if (D)
            togliD();

    }

   

    public void segnalaVassoioA()
    {
        if (!A)
        {
            ultimo = "A";
            SceneManager.LoadScene("SegnalazioneIdoneità", LoadSceneMode.Single);
        }
    }
    
    public void nonsegnalaA()
    {
        if (!A)
        {
            ultimo = "A";
            A = true;
            HashSet<int> temp= new HashSet<int>(){-1};
            risIdo.Add(ultimo, temp);
            togliA();
        }
    }

    private void togliA()
    {
        GameObject.Find("Segnala1").SetActive(false);
        GameObject.Find("NonSegnalare1").SetActive(false);
        c1.SetActive(true);
    }
    
    public void segnalaVassoioB()
    {
        if (!B)
        {
            ultimo = "B";
            SceneManager.LoadScene("SegnalazioneIdoneità", LoadSceneMode.Single);
        }
        
    }
    public void nonsegnalaB()
    {
        if (!B)
        {
            ultimo = "B";
            B = true;
            HashSet<int> temp= new HashSet<int>(){-1};
            risIdo.Add(ultimo, temp);
            togliB();
        }
        
    }

    private void togliB()
    {
        GameObject.Find("Segnala2").SetActive(false);
        GameObject.Find("NonSegnalare2").SetActive(false);
        c2.SetActive(true);
    }
    
    public void segnalaVassoioC()
    {
        if (!C)
        {
            ultimo = "C";
            SceneManager.LoadScene("SegnalazioneIdoneità", LoadSceneMode.Single);
        }
        
    }
    public void nonsegnalaC()
    {
        if (!C)
        {
            ultimo = "C";
            C = true;
            HashSet<int> temp= new HashSet<int>(){-1};
            risIdo.Add(ultimo, temp);
            togliC();
        }
        
    }

    private void togliC()
    {
        GameObject.Find("Segnala3").SetActive(false);
        GameObject.Find("NonSegnalare3").SetActive(false);
        c3.SetActive(true);
    }
    
    public void segnalaVassoioD()
    {
        if (!D)
        {
            ultimo = "D";
            SceneManager.LoadScene("SegnalazioneIdoneità", LoadSceneMode.Single);
        }
        
    }
    public void nonsegnalaD()
    {
        if (!D)
        {
            ultimo = "D";
            D = true;
            HashSet<int> temp= new HashSet<int>(){-1};
            risIdo.Add(ultimo, temp);
            togliD();
        }
        
    }

    private void togliD()
    {
        GameObject.Find("Segnala4").SetActive(false);
        GameObject.Find("NonSegnalare4").SetActive(false);
        c4.SetActive(true);
    }
    
    /*
     * pulsante torna indietro
     */
    public void TornaIndietro()
    {
        SceneManager.LoadScene("TestIdoneità", LoadSceneMode.Single);
    }

    
    /*
     *  pulsante invia segnalazione
     */
    public void termina()
    {
        switch (ultimo)
        {
            case "A": A = true;
                break;
            case "B": B = true;
                break;
            case "C": C = true;
                break;
            case "D": D = true;
                break;
            
        }
        
        if (risIdo.ContainsKey(ultimo))
        {
            foreach(KeyValuePair<string, HashSet<int>> el in risIdo)
            {
                if (el.Key == ultimo)
                {
                    foreach (var p in SegnalaAut.scelteAut)
                    {
                        el.Value.Add(p);
                    }
                }
            } 
        }
        else
        { 
            risIdo.Add(ultimo, new HashSet<int>());
            foreach (var p in SegnalaIdo.scelteId)
            {

                risIdo[ultimo].Add(p);
            }
        }
        SceneManager.LoadScene("TestIdoneità", LoadSceneMode.Single);
    }
    
   



    public void CalcolaPunteggio()
    {
          //SCELTE SEGNALAZIONE VASSOIO A
            foreach (var x in risIdo["A"])
            {
                if (x == 1 || x == 2)
                {
                    HomeManager.soldi += 10;
                    HomeManager.reputazione += 40;
                    parzialeSoldi += 10;
                    parzialeReputazione += 40;
                    //+10,+40
                }
                else
                {
                    //non segnalare
                    if (x == -1)
                    {
                        HomeManager.soldi -= 60;
                        HomeManager.reputazione -= 80;
                        parzialeSoldi -= 60;
                        parzialeReputazione -= 80;
                        //-60,-80
                        break;
                    }
                    //segnalazioni sbagliate
                    else
                    {
                        HomeManager.soldi -= 40;
                        HomeManager.reputazione -= 40;
                        parzialeSoldi -= 40;
                        parzialeReputazione -= 40;
                        //-40,-40
                    }
                }
            }
            
            //SCELTE SEGNALAZIONE VASSOIO B
            foreach (var x in risIdo["B"])
            {
                if (x == -1)
                {
                    HomeManager.soldi += 0;
                    HomeManager.reputazione += 20;
                    parzialeSoldi += 0;
                    parzialeReputazione += 20;
                    //+0,+20
                    break;
                }
                //ha segnalato
                else
                {
                    HomeManager.soldi -= 60;
                    HomeManager.reputazione -= 80;
                    parzialeSoldi -= 60;
                    parzialeReputazione -= 80;
                    //-60,-80
                    break;
                }
            }
            
            //SCELTE SEGNALAZIONE VASSOIO C
            foreach (var x in risIdo["C"])
            {
                if (x == -1)
                {
                    HomeManager.soldi += 0;
                    HomeManager.reputazione += 20;
                    parzialeSoldi += 0;
                    parzialeReputazione += 20;
                    //+0,+20
                    break;
                }
                //ha segnalato
                else
                {
                    HomeManager.soldi -= 60;
                    HomeManager.reputazione -= 80;
                    parzialeSoldi -= 60;
                    parzialeReputazione -= 80;
                    //-60,-80
                    break;
                }
            }
            
            //SCELTE SEGNALAZIONE VASSOIO D
            foreach (var x in risIdo["D"])
            {
                //non ha segnalato
                if (x == -1)
                {
                    HomeManager.soldi += 0;
                    HomeManager.reputazione += 20;
                    parzialeSoldi += 0;
                    parzialeReputazione += 20;
                    //+0,+20
                    break;
                }
                //ha segnalato
                else
                {
                    HomeManager.soldi -= 60;
                    HomeManager.reputazione -= 80;
                    parzialeSoldi -= 60;
                    parzialeReputazione -= 80;
                    //-60,-80
                    break;
                }
            }
    }
    
    
    
    public void punteggioManager()
    {
        if (risIdo.Count != 4)
        {
            if (!risIdo.ContainsKey("A"))
            {
                HashSet<int> temp= new HashSet<int>(){-1};
                risIdo.Add("A", temp);
            }
            if (!risIdo.ContainsKey("B"))
            {
                HashSet<int> temp= new HashSet<int>(){-1};
                risIdo.Add("B", temp);
            }
            if (!risIdo.ContainsKey("C"))
            {
                HashSet<int> temp= new HashSet<int>(){-1};
                risIdo.Add("C", temp);
            }
            if (!risIdo.ContainsKey("D"))
            {
                HashSet<int> temp= new HashSet<int>(){-1};
                risIdo.Add("D", temp);
            }
        }

       
        CalcolaPunteggio();
        HomeManager.controllo2 = true;
        cambiascena.Ido = true;
        EndgameManager.soldi[1] = parzialeSoldi;
        EndgameManager.reputazione[1] = parzialeReputazione;
        SceneManager.LoadScene("scelta", LoadSceneMode.Single);

    }
    
    
    public void tornaCeck()
    {
        SceneManager.LoadScene("HomeBanca", LoadSceneMode.Single);
    }
    
    
    
}
