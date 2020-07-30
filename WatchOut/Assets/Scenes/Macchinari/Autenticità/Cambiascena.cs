using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiascena : MonoBehaviour
{
    
    public static bool A=false;
    public static bool B=false;
    public static bool C=false;
    public static bool D=false;
    private static string ultimo;
    public static Dictionary<string, HashSet<int>> risAut = new Dictionary<string, HashSet<int>>();
    private  int parzialeSoldi=0;
    private  int parzialeReputazione=0;
    private GameObject check1;
    private GameObject check2;
    private GameObject check3;
    private GameObject check4;

    public static void reset()
    {
     A = false;
     B = false;
     C = false;
     D = false;
     ultimo="";
        risAut = new Dictionary<string, HashSet<int>>();
    }
    void Start()
    {
        check1 = GameObject.Find("check1");
        check1.SetActive(false); 
        check2 = GameObject.Find("check2");
        check2.SetActive(false); 
        check3 = GameObject.Find("check3");
        check3.SetActive(false);
        check4 = GameObject.Find("check4");
        check4.SetActive(false);

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
            SceneManager.LoadScene("SegnalazioneAutenticità", LoadSceneMode.Single);
        }
        
    }  
    public void nonsegnalaA()
    {
        if (!A)
        {
            ultimo = "A";
            A = true;
            HashSet<int> temp= new HashSet<int>(){-1};
            risAut.Add(ultimo, temp);
            togliA();
        }
        
    }

    private void togliA()
    {
        GameObject.Find("Segnala1").SetActive(false);
        GameObject.Find("NonSegnalare1").SetActive(false);
        check1.SetActive(true);
    }
    
    public void segnalaVassoioB()
    {
        if (!B)
        {
            ultimo = "B";
            SceneManager.LoadScene("SegnalazioneAutenticità", LoadSceneMode.Single);
        }
        
    }
    public void nonsegnalaB()
    {
        if (!B)
        {
            ultimo = "B";
            B = true;
            HashSet<int> temp= new HashSet<int>(){-1};
            risAut.Add(ultimo, temp);
            togliB();
        }
        
    }
    
    private void togliB()
    {
        GameObject.Find("Segnala2").SetActive(false);
        GameObject.Find("NonSegnalare2").SetActive(false);
        check2.SetActive(true);
    }
    
    public void segnalaVassoioC()
    {
        if (!C)
        {
            ultimo = "C";
            SceneManager.LoadScene("SegnalazioneAutenticità", LoadSceneMode.Single);
        }
        
    }
    public void nonsegnalaC()
    {
        if (!C)
        {
            ultimo = "C";
            C = true;
            HashSet<int> temp= new HashSet<int>(){-1};
            risAut.Add(ultimo, temp);
            togliC();
        }
        
    }
    private void togliC()
    {
        GameObject.Find("Segnala3").SetActive(false);
        GameObject.Find("NonSegnalare3").SetActive(false);
        check3.SetActive(true);
    }
    
    
    public void segnalaVassoioD()
    {
        if (!D)
        {
            ultimo = "D";
            SceneManager.LoadScene("SegnalazioneAutenticità", LoadSceneMode.Single);
        }
        
    }
    public void nonsegnalaD()
    {
        if (!D)
        {
            ultimo = "D";
            D = true;
            HashSet<int> temp= new HashSet<int>(){-1};
            risAut.Add(ultimo, temp);
            togliD();
        }
    }
    
    private void togliD()
    {
        GameObject.Find("Segnala4").SetActive(false);
        GameObject.Find("NonSegnalare4").SetActive(false);
        check4.SetActive(true);
    }
    
    
    
    public void TornaIndietro()
    {
        SceneManager.LoadScene("TestAutenticità", LoadSceneMode.Single);
    }

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

        if (risAut.ContainsKey(ultimo))
            {
                foreach(KeyValuePair<string, HashSet<int>> el in risAut)
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
              risAut.Add(ultimo, new HashSet<int>());
              foreach (var p in SegnalaAut.scelteAut)
              {
                  risAut[ultimo].Add(p);
              }
            }
        SceneManager.LoadScene("TestAutenticità", LoadSceneMode.Single);
    }
    
   
    
    private void CalcolaPunteggio()
    {
        
            //SCELTE SEGNALAZIONE VASSOIO A
            foreach (var x in risAut["A"])
            {
                //non ha segnalato
                if (x == -1)
                {
                    HomeManager.soldi += 0;
                    parzialeSoldi += 0;
                    parzialeReputazione += 30;
                    HomeManager.reputazione += 30;
                    //+0,+30
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
            
            //SCELTE SEGNALAZIONE VASSOIO B
            foreach (var x in risAut["B"])
            {
                //segnalazioni giuste
                if (x == 1 || x == 2)
                {
                    HomeManager.soldi += 30;
                    HomeManager.reputazione += 40;
                    parzialeSoldi += 30;
                    parzialeReputazione += 40;
                    //+30,+40
                }
                else
                {
                    //non ha segnalato
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
                        HomeManager.soldi -= 50;
                        HomeManager.reputazione -= 40;
                        parzialeSoldi -= 50;
                        parzialeReputazione -= 40;
                        //-50,-40
                    }
                }
            }
            
            //SCELTE SEGNALAZIONE VASSOIO C
            foreach (var x in risAut["C"])
            {
                //segnalazioni giuste
                if (x == 1 || x == 2)
                {
                    HomeManager.soldi += 30;
                    HomeManager.reputazione += 40;
                    parzialeSoldi += 30;
                    parzialeReputazione += 40;
                    //+30,+40
                }
                else
                {
                    //non ha segnalato
                    if (x == -1)
                    {
                        HomeManager.soldi -= 60;
                        HomeManager.reputazione -= 80;
                        parzialeSoldi -= 60;
                        parzialeReputazione -= 80;
                        //-60,-80
                    }
                    //segnalazioni sbagliate
                    else
                    {
                        HomeManager.soldi -= 50;
                        HomeManager.reputazione -= 40;
                        parzialeSoldi += 0;
                        parzialeReputazione += 30;
                        //-50,-40
                    }
                }
            }
            
            //SCELTE SEGNALAZIONE VASSOIO D
            foreach (var x in risAut["D"])
            {
                //non ha segnalato
                if (x == -1)
                {
                    HomeManager.soldi += 0;
                    HomeManager.reputazione += 30;
                    parzialeSoldi += 0;
                    parzialeReputazione += 30;
                    //+0,+30
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
        if (risAut.Count != 4)
        {
            if (!risAut.ContainsKey("A"))
            {
                HashSet<int> temp= new HashSet<int>(){-1};
                risAut.Add("A", temp);
            }
            if (!risAut.ContainsKey("B"))
            {
                HashSet<int> temp= new HashSet<int>(){-1};
                risAut.Add("B", temp);
            }
            if (!risAut.ContainsKey("C"))
            {
                HashSet<int> temp= new HashSet<int>(){-1};
                risAut.Add("C", temp);
            }
            if (!risAut.ContainsKey("D"))
            {
                HashSet<int> temp= new HashSet<int>(){-1};
                risAut.Add("D", temp);
            }
        }
        CalcolaPunteggio();
        HomeManager.controllo3 = true;
        cambiascena.aut = true;
        EndgameManager.soldi[2] = parzialeSoldi;
        EndgameManager.reputazione[2] = parzialeReputazione;
        SceneManager.LoadScene("scelta", LoadSceneMode.Single);

    }



    public void tornaCeck()
    {
        SceneManager.LoadScene("HomeBanca", LoadSceneMode.Single);
    }
    
    
    
}

