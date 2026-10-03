using UnityEngine;

public class TailMovement : MonoBehaviour
{
    public float speed = 8f;
    public float angle = 15f;

    private Quaternion startRotation;

    void Start()
    {
        startRotation = transform.localRotation;
    }

    void Update()
    {
        float rotation = Mathf.Sin(Time.time * speed) * angle;
        transform.localRotation = startRotation * Quaternion.Euler(0, rotation, 0);
    }
}