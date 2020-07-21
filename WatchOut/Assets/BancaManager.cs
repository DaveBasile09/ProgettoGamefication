using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BancaManager : MonoBehaviour
{
    /* GameObject */
    public GameObject popupTarm;
    public GameObject popupBpm;



    public static bool datiFiliale = true;
    public static bool macchine = true;
    public static bool versioneMacchine = true;




    public void segnalaDatiFiliale()
    {
        if(datiFiliale) UnityEngine.SceneManagement.SceneManager.LoadScene("SegnalaDatiFiliale",LoadSceneMode.Single);
    }

    public void segnalaMacchine()
    {
        if(macchine) UnityEngine.SceneManagement.SceneManager.LoadScene("SegnalaMacchine", LoadSceneMode.Single);
    }

    public void segnalaVersioneMacchinari()
    {
        if (versioneMacchine) UnityEngine.SceneManagement.SceneManager.LoadScene("SegnalaVersioneMacchine", LoadSceneMode.Single);
    }

    public static void tornaIndietro()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Banca", LoadSceneMode.Single);
    }

    public static void terminaSegnalazioneDatiFiliale()
    {
        datiFiliale = false;
        tornaIndietro();
    }

    public static void terminaSegnalazioneMacchine()
    {
        macchine = false;
        tornaIndietro();
    }

    public static void terminaSegnalazioneVersioneMacchine()
    {
        versioneMacchine = false;
        tornaIndietro();
    }

    public void showBpm()
    {
        StartCoroutine( ShowAndHide(popupBpm, 2.5f) ); 
    }
    
    
    public void showTarm()
    {
        StartCoroutine( ShowAndHide(popupTarm, 2.5f) ); 
    }
    
    
    IEnumerator ShowAndHide( GameObject go, float delay )
    {
        go.SetActive(true);
        yield return new WaitForSeconds(delay);
        go.SetActive(false);
    }

    public void tornaAllaChecklist()
    {
        SceneManager.LoadScene("HomeBanca", LoadSceneMode.Single);
    }

    public void concludiVerifica()
    {
        HomeManager.controllo1 = true;
        tornaAllaChecklist();
    }

}
