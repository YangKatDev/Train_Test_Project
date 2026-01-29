using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeSpawnerBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject bee;

    [SerializeField]
    float spawnAreaX, spawnAreaY, spawnAreaZ;

    void Start()
    {
       
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

            float randomX = Random.Range(-spawnAreaX, spawnAreaX);
            float randomY = Random.Range(-spawnAreaY / 3, spawnAreaY / 3);
            float randomZ = Random.Range(-spawnAreaZ, spawnAreaZ);

            Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);
            Instantiate(bee, randomPosition, Quaternion.identity);
        }
    }
}