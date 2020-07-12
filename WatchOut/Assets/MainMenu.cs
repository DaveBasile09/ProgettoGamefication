using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour

    
{
        public GameObject filiale1;
        public GameObject filiale2;
        public GameObject filiale3;
        public GameObject filiale4;
        public GameObject filiale5;
        public GameObject filiale6;
        public GameObject b1;
        public GameObject popup;
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
        b1.SetActive(false);

    }
    public void VienieVai()
    {
        StartCoroutine(ShowAndHide(popup, 2.0f)); // 1 second
    }
    IEnumerator ShowAndHide(GameObject go, float delay)
    {
        go.SetActive(true);
        yield return new WaitForSeconds(delay);
        go.SetActive(false);
    }


    public void Appari()
        {
        if (b1.active)
        {
            b1.SetActive(false);
        }
        else
        {
            b1.SetActive(true);
        }
            

        }
}
