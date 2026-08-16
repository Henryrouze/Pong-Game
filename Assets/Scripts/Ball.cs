using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private float speedIncreaseInterval = 5f;
    private float speedIncreaseAmount = 1f;
    private float maxSpeed = 20f;

    private Vector2 direction;
    public GameManager gameManager;
    private bool canMove = true;
    private float timeSinceLastGoal = 0f;
    private float startSpeed;
    private float initialdelay = 1f;

    void Start()
    {
        startSpeed = speed;
        Invoke("ResetBall", initialdelay);
        
    }

    void Update()
    {
        if (!canMove) return;

        transform.Translate(direction * speed * Time.deltaTime);

        timeSinceLastGoal += Time.deltaTime;
        if (timeSinceLastGoal >= speedIncreaseInterval)
        {
            IncreaseSpeed();
            timeSinceLastGoal = 0f;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Top wall"))
        {
            direction.y = -direction.y;
        }
        if (collision.gameObject.CompareTag("Bottom wall"))
        {
            direction.y = -direction.y;
        }
        if (collision.gameObject.CompareTag("Player 1"))
        {
            direction.x = -direction.x;
            AvoidFlatDirection();
        }
        if (collision.gameObject.CompareTag("Player 2"))
        {
            direction.x = -direction.x;
            AvoidFlatDirection();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Goal 1"))
        {
            gameManager.Goal2();
            ResetAfterGoal(1.5f);
        }
        if (other.gameObject.CompareTag("Goal 2"))
        {
            gameManager.Goal1();
            ResetAfterGoal(1.5f);
        }
    }

    void ResetAfterGoal(float delay)
    {
        transform.position = Vector2.zero;
        canMove = false;
        timeSinceLastGoal = 0f;
        speed = startSpeed;
        Invoke("ResetBall", delay);
    }

    void ResetBall()
    {
        LaunchBall();
        canMove = true;
    }

    void LaunchBall()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(-1f, 1f);
        direction = new Vector2(x, y);
        AvoidFlatDirection();
    }

    void AvoidFlatDirection()
    {
        if (direction.y > -0.3f && direction.y < 0.3f)
        {
            if (direction.y < 0f)
                direction.y = -0.3f;
            else
                direction.y = 0.3f;
        }
        direction.Normalize();
    }

    void IncreaseSpeed()
    {
        speed += speedIncreaseAmount;
        if (speed > maxSpeed)
            speed = maxSpeed;
    }
}
