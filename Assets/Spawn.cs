using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy; //Here we place the enemey Prefab in the Inspector

    public float minWaitTime = 1.5f; //This is the minimum time the spawner waits before spawning
    public float maxWaitTime = 3f; //This is the maximum time the spawner waits before spawning

    public float timer; //This is the countdown

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //At the beginning of the game we set the countdown to be random between two variables
        //In this case the minimum and maximum wait times.
        timer = Random.Range(minWaitTime, maxWaitTime);
    }

    // Update is called once per frame
    void Update()
    {
        //Every frame we check if the timer is more than 0
        if(timer > 0)
        {
            //If the timer is more than 0 it is not finished counting down
            //Therefor we subtract from the timer, making it count down
            //We multiply by Time.deltaTime as that translates time between the frames.
            //This makes it a stable time messure unrelated to 30fps or 60fps
            timer -= 1 * Time.deltaTime;
        }
        else
        {
            //When the timer is 0 or less we start spawning the enemy.
            Instantiate(enemy, transform.position, Quaternion.identity);

            //And then we set the timer again.
            timer = Random.Range(minWaitTime, maxWaitTime);
        }

    }
}
