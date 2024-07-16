using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // M�todo para iniciar el juego, cargando la siguiente escena en el �ndice de compilaci�n
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // M�todo para salir del juego
    public void Salir()
    {
#if UNITY_EDITOR
            // Para detener la reproducci�n del juego en el editor de Unity
            UnityEditor.EditorApplication.isPlaying = false;
#else
        // Para cerrar el juego cuando est� en ejecuci�n como aplicaci�n
        Application.Quit();
#endif
    }
}
