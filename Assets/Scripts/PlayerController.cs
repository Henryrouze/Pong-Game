using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime); 
        }
        if (transform.position.y > 4.27f)
        {
            transform.position = new Vector2(transform.position.x, 4.27f);
        }
        if (transform.position.y < -4.27f)
        {
            transform.position = new Vector2(transform.position.x, -4.27f);
        }
    }
}
