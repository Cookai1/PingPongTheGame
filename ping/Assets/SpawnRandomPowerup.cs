using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomPowerup : MonoBehaviour
{
    public float SpawnPowerupTime;
    public float curTime;
    private List<objectSpawnInfo> objectsToSpawn = new List<objectSpawnInfo>();
    private List<spawnPointInfo> spawnPoints = new List<spawnPointInfo>();
    private Transform thisTransform;
    public struct spawnPointInfo
    {
        public GameObject spawnPoint;
    }
    public struct objectSpawnInfo
    {
        public GameObject item;
    }

    void Start()
    {
        curTime = 0f;

    }


    void Update()
    {
        curTime += Time.deltaTime;
        if (curTime > SpawnPowerupTime)
        {
            SpawnObject();

            curTime = 0f;
        }
    }
    void SpawnObject()
    {


    }


    IEnumerator powerupTimer(Pabble p)
    {
        yield return new WaitForSeconds(10f);
    }

}