using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> cars = new List<GameObject>(3);
    Vector3 spawnPos = new Vector3(5, 0, 80);
    Vector3 spawnPos2 = new Vector3(-5, 0, 100);
    private float Timer = 2;
    private float spawnRate = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomCar", Timer, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void RandomCar()
    {
        float sideOfTheRoad = Random.Range(-5, 5);
        int indexCar = Random.Range(0, cars.Count);
        if(sideOfTheRoad > 0)
        {
            Instantiate(cars[indexCar], spawnPos, transform.rotation);
        }
        else
        {
            Instantiate(cars[indexCar], spawnPos2, transform.rotation * Quaternion.Euler(0, 180, 0));
        }
    }
}
