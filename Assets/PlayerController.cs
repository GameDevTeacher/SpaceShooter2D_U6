using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 10; //The speed variable is used to change the movement speed of the player
    public float left, right; //We can create two variables of the same type this way. These are going to be used later.
    public float horizontalAxis; //This variable is to make the final code easier to read. 

    public Rigidbody2D _rigidbody2D; //Rigidbody give the GameObject physics. 

    public GameObject bullet; //We store the Bullet Prefab here so our code can create a copy.
    public Transform bulletSpawn; //This Transform stores position in gamespace. 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnDestroy()
    {
        //This code loads the current scene.
        SceneManager.LoadScene("Main Menu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.isPressed) //When the A key is pressed
        {
            left = -1;
        }
        else
        {
            left = 0; 
        }
        if (Keyboard.current.dKey.isPressed) //When the D key is pressed
        {
            right = 1;
        }
        else
        {
            right = 0;
        }

        //This line of code use basic math to convert our inputs to placement on an Axis, between -1 and 1. 
        //Creating movement towards the left or right based on key input, and creates no movement when both or no key are pressed. 
        //-1 + 1 = 0
        //-1 + 0 = -1 
        // 0 + 1 = 1 
        // 0 + 0 = 0 
        horizontalAxis = left + right;

        //Here we convert the horizontal input to physical velocity on the object. We create a new Vector2 with the input from keyboard.
        //We multiply this with speed, giving the designer more control over how fast the player should move. 
        _rigidbody2D.linearVelocity = new Vector2(horizontalAxis, 0) * speed;



        if (Keyboard.current.spaceKey.wasPressedThisFrame) //the frame we press the Space key.
        {
            //Instantiate is a way to create GameObjects through code. We use the bullet as a template, and create it at the bulletSpawn position.
            //Quaternion.identity is the objects rotation. 
            Instantiate(bullet, bulletSpawn.position, Quaternion.identity); 
        }

    }
}
