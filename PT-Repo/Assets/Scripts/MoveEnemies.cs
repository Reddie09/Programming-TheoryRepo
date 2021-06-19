using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//INHERITANCE
public class MoveEnemies : MoveDown
{
    private float speedX;
    // Start is called before the first frame update
    void Start()
    {
        speedX = Random.Range(10, 20);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        DestroyOutOfBounds();
    }
    // POLYMORPHISM
    protected override void Move()
    {
        if(transform.position.x < 0)
        {
            transform.Translate(Vector3.forward * (speed + speedX) * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.forward * - (speed - speedX) * Time.deltaTime);
        }
    }
    private void DestroyOutOfBounds()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
