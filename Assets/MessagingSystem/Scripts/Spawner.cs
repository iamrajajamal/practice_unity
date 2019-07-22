using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public int spawnCount;
    [Range(1, 100)]
    public int spawnSize = 1;
    public float minionOffset = 1;
    public GameObject minion;


    void OnEnable()
    {
        EventManager.StartListening("Spawn", Spawn);
    }

    private void OnDisable()
    {
        EventManager.StopListening("Spawn", Spawn);
    }

    private void Spawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            Vector3 spawnPosition = GetSpawnPosition();

            Quaternion spawnRotation = new Quaternion();

            spawnRotation.eulerAngles = new Vector3(0.0f, Random.Range(0.0f, 360f));
            if (spawnPosition != Vector3.zero)
                Instantiate(minion, spawnPosition, spawnRotation);
        }
    }

    private Vector3 GetSpawnPosition()
    {
        Vector3 spawnPosition = new Vector3();
        float startTime = Time.realtimeSinceStartup;
        bool test = false;
        while (test == false)
        {
            Vector2 spawnPositionRaw = Random.insideUnitSphere * spawnSize;
            spawnPosition = new Vector3(spawnPositionRaw.x, minionOffset, spawnPositionRaw.y);
            test = !Physics.CheckSphere(spawnPosition, 0.75f);
            if (Time.realtimeSinceStartup - startTime > 0.5f)
            {
                Debug.Log("Time out placing Minion!");
                return Vector3.zero;
            }
        }
        return spawnPosition;
    }
}
