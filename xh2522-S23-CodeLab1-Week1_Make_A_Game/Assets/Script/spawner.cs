using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnRate = .5f;
    public GameObject circlePrefab;
    private float nextTimeToSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time>=nextTimeToSpawn)
        {
            Instantiate(circlePrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }
}
