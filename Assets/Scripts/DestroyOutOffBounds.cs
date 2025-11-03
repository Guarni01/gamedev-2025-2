using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOutOffBounds : MonoBehaviour
{
    public bool isCausingGameOver = false; //bool può essere o vero o falso

    private float topBound = 30;
    private float bottomBound = -10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound || transform.position.z < bottomBound)  //  || vuol dire oppure
        {
            Destroy(gameObject);

            if (isCausingGameOver)
            {
                Debug.Log("Game over!!! sei una pippa");
                //SceneManager.LoadScene(0); x ricaricare a scena iniziale ma non funziona bene
            }
        }

    }
}
