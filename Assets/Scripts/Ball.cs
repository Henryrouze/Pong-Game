using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(-1f, 1f);
        direction = new Vector2(x, y).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Top wall"))
        {
            direction.y = -direction.y;
        }
            if(collision.gameObject.CompareTag("Bottom wall"))
        {
            direction.y = -direction.y;
        }
            if(collision.gameObject.CompareTag("Player 1"))
        {
            direction.x = -direction.x;
        }
            if(collision.gameObject.CompareTag("Player 2"))
        {
            direction.x = -direction.x;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Goal 1"))
        {
            Debug.Log("Goal 1");
        }
        if(other.gameObject.CompareTag("Goal 2"))
        {
            Debug.Log("Goal 2");
        }
    }
}
