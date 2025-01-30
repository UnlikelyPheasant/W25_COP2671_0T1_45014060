using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{

    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Whenever a gameObject goes past the players field of view that object is destroyed
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound) 
        {
            Debug.Log("Game Over"); // Log game over if an animal is missed and goes past the player
            Destroy(gameObject);
        }
    }
}
