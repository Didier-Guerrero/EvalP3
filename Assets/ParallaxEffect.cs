using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    private float length, startPos;
    public float parallaxSpeed;

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float dist = Time.deltaTime * parallaxSpeed;
        transform.position = new Vector3(transform.position.x + dist, transform.position.y, transform.position.z);

        if (transform.position.x > startPos + length)
        {
            transform.position = new Vector3(startPos, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < startPos - length)
        {
            transform.position = new Vector3(startPos, transform.position.y, transform.position.z);
        }
    }
}
