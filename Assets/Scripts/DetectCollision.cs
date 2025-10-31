using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public int hitsRequired = 1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {   // TAKES ONE HIT
        hitsRequired--;

        if (hitsRequired == 0)
        {

            Destroy(gameObject);
            
        }
        Destroy(other.gameObject);
    }
}
