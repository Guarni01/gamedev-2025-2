using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange;
    public float zRangeMax;
    public float zRangeMin;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, //x
                                             transform.position.y, //y
                                             transform.position.z); //z
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, //x
                                             transform.position.y, //y
                                             transform.position.z); //z
        }
        if (transform.position.z < zRangeMin)
        {
            transform.position = new Vector3(transform.position.x,
                                             transform.position.y,
                                             zRangeMin);
        }
        if (transform.position.z > zRangeMax)
        {
            transform.position = new Vector3(transform.position.x,
                                             transform.position.y,
                                             zRangeMax);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation); //lancia un proiettile dal player
            
        }

    }
}
