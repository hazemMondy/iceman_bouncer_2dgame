using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateSpawner : MonoBehaviour
{
    public GameObject platePrefab;
    public GameObject[] speedPrefab;
    public GameObject breakPrefab;
    public GameObject deathPrefab;

    public float spawnTimer = 1.8f;
    public float currentTime;

    private int spawnCount;

    public float minX = -1.8f, maxX = 1.8f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        spawn();
    }
    void spawn()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= spawnTimer)
        {
            spawnCount++;

            Vector3 temp = transform.position;
            temp.x = Random.Range(minX,maxX);

            GameObject newplate = null;

            if (spawnCount < 2)
            {
                newplate = Instantiate(platePrefab, temp,Quaternion.identity);
            }
            else if (spawnCount == 2)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newplate = Instantiate(platePrefab, temp, Quaternion.identity);
                }
                else
                {
                    newplate = Instantiate(speedPrefab[Random.Range(0, speedPrefab.Length)],
                        temp, Quaternion.identity);
                }
            }
            
            else if (spawnCount == 3)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newplate = Instantiate(platePrefab, temp, Quaternion.identity);
                }
                else
                {
                    newplate = Instantiate(deathPrefab,temp, Quaternion.identity);
                }
            }
            else if (spawnCount == 4)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newplate = Instantiate(platePrefab, temp, Quaternion.identity);
                }
                else
                {
                    newplate = Instantiate(breakPrefab,temp, Quaternion.identity);
                }
                spawnCount = 0;
            }
            if (newplate)
            {
                newplate.transform.parent = transform;
            }
            currentTime = 0;
        } 
    }
}
