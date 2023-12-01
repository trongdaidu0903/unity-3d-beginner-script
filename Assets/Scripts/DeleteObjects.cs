using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObjects : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Call destroy objects");
            GameObject[] objectsB = GameObject.FindGameObjectsWithTag("ObjectB");
            StartCoroutine(DeleteObjectsWithDelay(objectsB));
        }
    }

    IEnumerator DeleteObjectsWithDelay(GameObject[] objectsB)
    {
        yield return new WaitForSeconds(2f);

        while (objectsB.Length > 0)
        {
            GameObject objectToDelete = objectsB[Random.Range(0, objectsB.Length)];
            Destroy(objectToDelete);
            objectsB = GameObject.FindGameObjectsWithTag("ObjectB");
            yield return null;
        }
    }
}
