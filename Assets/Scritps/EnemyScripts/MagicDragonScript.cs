using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicDragonScript : EnemyScript
{
    private float _teleportRange;
    private PlayerMove _playerScritp;
    // Start is called before the first frame update
    void Start()
    {
        _playerScript = GameObject.Find("Player").GetComponent<PlayerMove>();
        
    }

    // Update is called once per frame
    void Update()
    {
        _teleportRange = Random.Range(1, 1);
        Destroy();
        DestroyOut();
    }
    public override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            _hp--;
            transform.Translate(Vector3.right * _teleportRange);
        }

        if (transform.position.x > 2.5 || transform.position.x < -2.5)
        {
            transform.position = new Vector3(0,0,30);
        }
        
    }
}
