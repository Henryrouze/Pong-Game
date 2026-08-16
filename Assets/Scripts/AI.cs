using UnityEngine;

public class AI : MonoBehaviour
{
    public Transform ball;
    public float speed;
    public float reactionTime;
    private float error;
    private float targetY;
    private float timer;
    void Start()
    {
        if (!GameMode.isPVE)
        {
            enabled = false;
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > reactionTime)
        {
            CalculateTargetY();
            timer = 0;
        }
            transform.Translate(0, (targetY - transform.position.y) * Time.deltaTime * speed, 0);
        // Invisible walls
        if (transform.position.y > 4.27f)
        {
            transform.position = new Vector2(transform.position.x, 4.27f);
        }
        if (transform.position.y < -4.27f)
        {
            transform.position = new Vector2(transform.position.x, -4.27f);
        }
        
    }
    void CalculateTargetY()
    {
        error = Random.Range(-0.5f, 0.5f);
        targetY = ball.position.y + error;
    }
}
