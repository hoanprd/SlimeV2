using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject crossBar;
    public float timeSpawnCrossBar;

    private int horizontalPosition;
    private float timeOG;
    private Vector3 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        timeOG = timeSpawnCrossBar;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSpawnCrossBar > 0)
        {
            timeSpawnCrossBar -= Time.deltaTime;
            if (timeSpawnCrossBar <= 0)
            {
                timeSpawnCrossBar = timeOG;

                horizontalPosition = Random.Range(-5, 6);
                spawnPos = new Vector3(horizontalPosition, -6.5f, 0);

                Instantiate(crossBar, spawnPos, Quaternion.identity);
            }
        }
    }
}
