using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnalisiNormativa : MonoBehaviour
   
{
public GameObject tablet;
public void presenzaNormativa(string scenename)
        {
            SceneManager.LoadScene(scenename, LoadSceneMode.Single);
    }
}
