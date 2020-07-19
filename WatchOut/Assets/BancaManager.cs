using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BancaManager : MonoBehaviour
{
    public void segnalaDatiFiliale()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SegnalaDatiFiliale",LoadSceneMode.Single);
    }

    public void segnalaMacchine()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SegnalaMacchine", LoadSceneMode.Single);
    }

    public void segnalaVersioneMacchinari()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SegnalaVersioneMacchine", LoadSceneMode.Single);
    }

    public static void tornaIndietro()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Banca", LoadSceneMode.Single);
    }

}
