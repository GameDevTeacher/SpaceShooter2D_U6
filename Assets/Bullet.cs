using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15; //The speed variable is used to control how fast the bullet move
    public float despawnTimer = 5; //This variable determines the time before the GameObject is destroyed
    
    public Rigidbody2D _rigidbody2D; //Rigidbody give the GameObject physics.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //This is a Function we can call on to destroy an object.
        //The first part in the () says what object we are destroying
        //in this case it's this GameObject (noted by the small g)
        //The second part is how many seconds from the call is made
        Destroy(gameObject, despawnTimer); 
    }

    // Update is called once per frame
    void Update()
    {
        //Since bullets constantly move we don't have to check for any input,
        //just constantly add velocity to the object. 
        _rigidbody2D.linearVelocity = new Vector2(0, 1) * speed;
        
    }
}
