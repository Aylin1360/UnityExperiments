﻿using UnityEngine; 
using System.Collections; 


public class RandomTimeSpawner : MonoBehaviour {

    //Spawn this object

    //Note: Change this to object pooling.
    public GameObject spawnObject;

    public float maxTime = 5;
    public float minTime = 2;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    void Start(){
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate(){

        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if(time >= spawnTime){
            SpawnObject();
            SetRandomTime();
        }

    }

    //Spawns the object and resets the time
    void SpawnObject(){
        time = 0; 
        Instantiate (spawnObject, transform.position, spawnObject.transform.rotation);
    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime(){
        spawnTime = Random.Range(minTime, maxTime);
    }

}