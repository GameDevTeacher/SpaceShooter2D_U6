using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1; //The speed variable is used to control how fast the enemy moves
    public float despawnTimer = 10; //This variable determines the time before the GameObject is destroyed

    public Rigidbody2D _rigidbody2D;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Just like in the Bullet Script we destroy the enemy after a given time
        Destroy(gameObject, despawnTimer);
    }

    // Update is called once per frame
    void Update()
    {
        //This line makes the enemies constantly move down. 
        _rigidbody2D.linearVelocity = new Vector2(0, -1) * speed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //This line of code destroys the enemy when it collides with anything, in addition to destroying what it collieds with.
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
