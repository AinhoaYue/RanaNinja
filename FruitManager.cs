using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FruitManager : MonoBehaviour
{
    private bool gameEnded = false;

    private void Update()
    {
        if (!gameEnded && transform.childCount == 0)
        {
            gameEnded = true;
            Debug.Log("No quedan frutas, !!!!VICTORIA!!!!");

            // Cambiar de escena
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}