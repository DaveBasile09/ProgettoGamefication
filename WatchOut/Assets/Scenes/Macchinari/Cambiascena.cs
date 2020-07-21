﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiascena : MonoBehaviour
{
    
    public static bool A=false;
    public static bool B=false;
    public static bool C=false;
    public static bool D=false;
    private static string ultimo;
    
    public void segnalaVassoioA()
    {
        if (!A)
        {
            ultimo = "A";
            SceneManager.LoadScene("SegnalazioneAutenticità", LoadSceneMode.Single);
        }
        
    }
    
    public void segnalaVassoioB()
    {
        if (!B)
        {
            ultimo = "B";
            SceneManager.LoadScene("SegnalazioneAutenticità", LoadSceneMode.Single);
        }
        
    }
    
    public void segnalaVassoioC()
    {
        if (!C)
        {
            ultimo = "C";
            SceneManager.LoadScene("SegnalazioneAutenticità", LoadSceneMode.Single);
        }
        
    }
    
    public void segnalaVassoioD()
    {
        if (!D)
        {
            ultimo = "D";
            SceneManager.LoadScene("SegnalazioneAutenticità", LoadSceneMode.Single);
        }
        
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
        SceneManager.LoadScene("TestAutenticità", LoadSceneMode.Single);
        
    }
    
}
