using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Parallax : MonoBehaviour
{
    public float parallaxSpeed; // La velocidad del parallax
    public float delayTime = 1.0f; // Tiempo de espera antes de reposicionar la imagen
    public float resetPointX; // El punto en el eje X donde se debe reposicionar la imagen
    private RectTransform rectTransform;
    private Vector2 startPos;
    private bool isWaiting = false;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        startPos = rectTransform.anchoredPosition;
    }

    void Update()
    {
        if (!isWaiting)
        {
            float dist = Time.deltaTime * parallaxSpeed;
            rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x + dist, rectTransform.anchoredPosition.y);

            if ((parallaxSpeed > 0 && rectTransform.anchoredPosition.x >= resetPointX) ||
                (parallaxSpeed < 0 && rectTransform.anchoredPosition.x <= resetPointX))
            {
                StartCoroutine(ResetPositionAfterDelay());
            }
        }
    }

    private IEnumerator ResetPositionAfterDelay()
    {
        isWaiting = true;
        yield return new WaitForSeconds(delayTime);
        rectTransform.anchoredPosition = startPos;
        isWaiting = false;
    }
}
