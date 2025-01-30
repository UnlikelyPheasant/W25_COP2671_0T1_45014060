using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // If a projectile comes into the collider of an animal gameObject they are both detroyed
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
