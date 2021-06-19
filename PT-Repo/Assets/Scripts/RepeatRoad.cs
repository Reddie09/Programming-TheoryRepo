using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatRoad : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatRate;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatRate = GetComponent<BoxCollider>().size.z/3;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < startPos.z - repeatRate)
        {
            transform.position = startPos;
        }
    }
}
