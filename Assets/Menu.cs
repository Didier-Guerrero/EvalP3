using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Método para iniciar el juego, cargando la siguiente escena en el índice de compilación
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Método para salir del juego
    public void Salir()
    {
#if UNITY_EDITOR
            // Para detener la reproducción del juego en el editor de Unity
            UnityEditor.EditorApplication.isPlaying = false;
#else
        // Para cerrar el juego cuando está en ejecución como aplicación
        Application.Quit();
#endif
    }
}
