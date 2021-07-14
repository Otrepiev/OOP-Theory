using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGo : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWith;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 0 )
        {
            transform.position = startPos;  
        }
    }
}