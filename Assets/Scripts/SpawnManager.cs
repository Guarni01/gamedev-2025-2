using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float xRange;
    public GameObject[] animalPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimals), 2.5f, 2.0f);

    }

    // Update is called once per frame
    void Update()
    {

    }



    void SpawnRandomAnimals()
    {
        int animalIndex; // possiamo anche scrivere qua =0
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), transform.position.y, transform.position.z);

        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}