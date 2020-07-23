using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiascenaIdoneita : MonoBehaviour
{
   
    public static bool A=false;
    public static bool B=false;
    public static bool C=false;
    public static bool D=false;
    public static string ultimo;
    public static Dictionary<string, HashSet<int>> risIdo = new Dictionary<string, HashSet<int>>();
    
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
        }
        
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
        }
        
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
        }
        
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
        }
        
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
            foreach (var p in SegnalaAut.scelteAut)
            {
                risIdo[ultimo].Add(p);
            }
        }
        SceneManager.LoadScene("TestIdoneità", LoadSceneMode.Single);
    }
    
   



    public void CalcolaPunteggio()
    {
        /*
         * QUI ANDRA' CALCOLATO IL PUNTEGGIO FINALE DEI VARI VASSOI DEL TEST D'IDONEITA'
         */
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
        SceneManager.LoadScene("scelta", LoadSceneMode.Single);

    }
    
    
    
    
    
    
}
