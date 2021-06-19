using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    //ENCAPSULATION
    private float n_Speed = 35;
    public float speed 
    {
        get
        {
            return n_Speed;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
