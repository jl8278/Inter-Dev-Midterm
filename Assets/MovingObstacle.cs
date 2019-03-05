using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float ObMinPosZ;
    public float ObMaxPosz;
    public float ObMinPosX;
    public float ObMaxPosX;

    public GameObject Player;
    public Transform movingObstacles;
    public GameObject MovingObs;

    public float SpawnObstacleTime;
    public float PlayerminX;
    public float PlayerminY;
    public float PlayerminZ;

    public float PlayermaxX;
    public float PlayermaxY;
    public float PlayermaxZ;


    public float ObminX;
    public float ObminY;
    public float ObminZ;

    public float ObmaxX;
    public float ObmaxY;
    public float ObmaxZ;

    //public float stopTime;



    public Transform ObstacleSpawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        SpawnObstacleTime = SpawnObstacleTime + 1;
        if (SpawnObstacleTime > 3)
        {

            SpawnMovingObstacle();
            //stopTime = stopTime - 1;
        }




        void SpawnMovingObstacle()
        {


            Vector3 SpawnPos = new Vector3(Random.Range(ObminX, ObmaxX), Random.Range(ObminY, ObmaxY), Random.Range(ObminZ, ObmaxZ));


            if (Player.transform.position.z < MovingObs.transform.position.z)
            {

                Instantiate(MovingObs, SpawnPos, Quaternion.identity);

                MovingObs.transform.Translate(0, 0, movingObstacles.position.z + 1);


            }


        }
    }
}
