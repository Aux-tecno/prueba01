using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambio : MonoBehaviour
{
    public void CambiarEscena(int nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
