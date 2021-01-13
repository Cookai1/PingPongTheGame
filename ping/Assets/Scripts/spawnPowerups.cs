using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
public class spawnPowerups : MonoBehaviour
{
    public float SpawnPowerupTime;
    [SerializeField]
    private List<spawnPointInfo> spawnPoints = new List<spawnPointInfo>();
    [SerializeField]
    private List<objectSpawnInfo> objectsToSpawn = new List<objectSpawnInfo>();
    private Terrain terrain;
    private Transform thisTransform;
    public float curTime;
    [System.Serializable]
    public struct objectSpawnInfo
    {
        public GameObject item;
    }
    [System.Serializable]
    public struct spawnPointInfo
    {
        public GameObject spawnPoint;
    }
    void Start()
    {

        curTime = 0f;
        thisTransform = transform;private List<objectSpawnInfo> objectsToSpawn = new List<objectSpawnInfo>();
}
    void Update()
    {

        curTime += Time.deltaTime;
        if (curTime > SpawnPowerupTime)
        {
            StartSpawn();

            curTime = 0f;
        }
    }
    void StartSpawn()
    {

        for (int i = 0; i < spawnPoints.Count; i++)
        {

            if (spawnPoints[i].spawnPoint.transform.childCount == 0 /**|| spawnPoints[i].spawnPoint.transform.childCount == null**/)
            {
                int itemIndex = Random.Range(0, (objectsToSpawn.Count));
                Spawn(spawnPoints[i].spawnPoint, objectsToSpawn[itemIndex].item);
            }
        }
    }
    void Spawn(GameObject sp, GameObject item)
    {

        GameObject locObj = Instantiate(item).gameObject;
        locObj.transform.position = new Vector3(sp.transform.position.x, sp.transform.position.y, sp.transform.position.z);
        Vector3 euler = locObj.transform.eulerAngles;
        euler.y = Random.Range(0f, 0f);
        locObj.transform.eulerAngles = euler;

        locObj.transform.parent = sp.transform;
        /**if (Network.isServer)
        {
            NetworkServer.Spawn(locObj);
        }**/
    }
}