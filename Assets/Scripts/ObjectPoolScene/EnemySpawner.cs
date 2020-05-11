using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float intervalMin = 0.1f; //min time to span new star
    public float intervalMax = 0.5f; //max time to span new star
    public float numEnemies = 1; //how many stars to span at once

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", intervalMin); //call SpawnStar after intervalMin time
    }

    void SpawnEnemy()
    {
        //generate numStars stars
        for (int i = 0; i < numEnemies; i++)
        {
            GameObject enemy = EnemyPool.instance.GetEnemy();
        }

        //call SpawnStar again after a random amount of time between min and max
        Invoke("SpawnEnemy", Random.Range(intervalMin, intervalMax));
    }
}
