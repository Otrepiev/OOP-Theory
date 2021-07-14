using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float _hp;
    [SerializeField] private float _speed;
    [SerializeField]private float pointValue;

    protected PlayerMove _playerScript;
    // Start is called before the first frame update
    void Start()
    {
        _playerScript = GameObject.Find("Player").GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        DestroyOut();
    }

    void Update()
    {
       
        Destroy();
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
                _hp--;
        }
    }

    public void Destroy()
    {
        if (_hp == 0)
        {
            Destroy(gameObject);
        }
    }

    public void DestroyOut()
    {
        if (transform.position.z < -14)
        {
            Destroy(gameObject);
            _playerScript.PlayerHit();
        }
    }
    
}

