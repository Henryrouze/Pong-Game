using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (GameMode.isPVE == true)
        {
            enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
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
