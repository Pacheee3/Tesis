using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menuprincipalversionfinal : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }
    public void Salir()
    {
        Debug.Log("salirdeljuego");
            Application.Quit();
    }
    public void Controles()
    {
        SceneManager.LoadScene(3);
    }
}
