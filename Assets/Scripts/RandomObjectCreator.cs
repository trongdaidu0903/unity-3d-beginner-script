using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectCreator : MonoBehaviour
{
    public GameObject capsulePrefab;
    public GameObject objectBPrefab;
    public float minY = 10f;
    public float maxY = 20f;
    public float forceMagnitude = 10f;

    void Start()
    {
        float randomX = Random.Range(10f, 20f);

        Vector3 spawnPosition = new Vector3(0f, randomX, 0f);
        GameObject newCapsule = Instantiate(capsulePrefab, spawnPosition, Quaternion.identity);
        newCapsule.name = "RandomCapsule";
        newCapsule.tag = "ObjectB";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float randomX = Random.Range(-10f, 10f);
            float randomZ = Random.Range(-10f, 10f);
            float randomY = Random.Range(minY, maxY);

            Vector3 spawnPosition = new Vector3(randomX, randomY, randomZ);

            GameObject newObjectB = Instantiate(objectBPrefab, spawnPosition, Quaternion.identity);

            Rigidbody rb = newObjectB.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.useGravity = true;
                Vector3 forceDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
                rb.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
            }
        }
    }
}
