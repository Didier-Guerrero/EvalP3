using UnityEngine;

public class TitleBounceEffect : MonoBehaviour
{
    public float scaleAmount = 0.1f; // La cantidad m�xima de escalado
    public float speed = 2f; // La velocidad de la animaci�n

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale; // Guardar la escala original del objeto
    }

    void Update()
    {
        // Calcular la nueva escala utilizando una funci�n sinusoidal
        float scale = 1 + Mathf.Sin(Time.time * speed) * scaleAmount;
        transform.localScale = originalScale * scale;
    }
}
