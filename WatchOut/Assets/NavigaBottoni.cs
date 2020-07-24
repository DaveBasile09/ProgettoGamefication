using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigaBottoni : MonoBehaviour
{
   public void master()
   {
      SceneManager.LoadScene("Banca", LoadSceneMode.Single);

   }
   public void operatore()
   {
      SceneManager.LoadScene("Chiedi_Operatore", LoadSceneMode.Single);

   }
   public void macchine()
   {
      SceneManager.LoadScene("scelta", LoadSceneMode.Single);

   }
}
