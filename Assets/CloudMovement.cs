using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    private float moveSpeed;

    void Start()
    {
        // Every cloud moves at a slightly different speed
        moveSpeed = Random.Range(0.6f, 1.5f);
    }

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        // Destroy cloud after it leaves the screen
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}