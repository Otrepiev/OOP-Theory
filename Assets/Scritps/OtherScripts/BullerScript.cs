using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullerScript : MonoBehaviour
{   
    private Rigidbody _bulletRb;
    [SerializeField]private float _bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _bulletRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _bulletRb.AddForce(0,0,_bulletSpeed * Time.deltaTime, ForceMode.Acceleration);
        if (transform.position.z > 100)
        {
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
