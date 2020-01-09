using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script handles spawning enemies.
public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float adjustmentAngle = 270;
    public void Spawn(GameObject objectToSpawn)
    {
        Vector3 rotationInDegrees = transform.eulerAngles;
        rotationInDegrees.z += adjustmentAngle;
        Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
        Instantiate(objectToSpawn, transform.position, rotationInRadians);
    }
}