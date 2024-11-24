using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
   public int CurrentScore; 
   public GameObject[] TotalCoins;

    private void OnTriggerEnter(Collider PickUp)
    {
        if (PickUp.gameObject.CompareTag("Coin")) 
        {
          Destroy(PickUp.gameObject);
          CurrentScore++;
        }

        if (PickUp.gameObject.CompareTag("KillZone")) {SceneManager.LoadScene(SceneManager.GetActiveScene().name);}
    }

    private void Start()
    {
      TotalCoins = GameObject.FindGameObjectsWithTag("Coin");
    }
}
