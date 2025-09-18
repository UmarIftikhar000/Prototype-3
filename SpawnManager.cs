using UnityEngine;

public class SpawnManager : MonoBehaviour

{
    public GameObject obstaclePrefab;
    public float repeatDelay = 2;
    public float startDelay = 2;
    private Vector3 spawnPose = new Vector3(25, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandom", startDelay, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandom()
    {
        Instantiate(obstaclePrefab, spawnPose, obstaclePrefab.transform.rotation);
    }
}
