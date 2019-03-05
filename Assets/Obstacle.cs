using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public Vector3 center;
    public Vector3 size;
    public GameObject ObstaclePrefab;

    public float CountDownTimer;
    private float restartTimer;



    void Start()
    {
        restartTimer = 4;

        restartTimer = CountDownTimer;
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {



            CountDownTimer = CountDownTimer - 1;

            if (CountDownTimer >= 0)
            {
                SpawnObstacles();
            }

            if (CountDownTimer < 0)
            {

                CountDownTimer = restartTimer;
            }
        }
    }

    void SpawnObstacles()
    {


        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        Instantiate(ObstaclePrefab, pos, Quaternion.identity);
    
    }
}

