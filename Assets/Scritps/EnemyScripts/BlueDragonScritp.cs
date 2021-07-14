using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDragonScritp : EnemyScript
{
    [SerializeField] private GameObject _enemyMeteor;
    [SerializeField] private GameObject _MeteorSpawner;
    private PlayerMove _playerScritp;

    // Start is called before the first frame update
    void Start()
    {
        _playerScript = GameObject.Find("Player").GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        Destroy();
        DestroyOut();
    }

    public override void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            _hp--;
            Instantiate(_enemyMeteor, _MeteorSpawner.transform.position, Quaternion.identity);
        }
    }

}