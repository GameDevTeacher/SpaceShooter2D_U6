using UnityEngine;

public class Killbox : MonoBehaviour
{
    //This function happens when two objects with colliders hit each other. 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Here we call the destroy function to destroy the GameObject of the colliding object. 
        Destroy(collision.gameObject);
    }
}
