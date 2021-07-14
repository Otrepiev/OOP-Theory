using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float horizontalInput;
    public int _hpPlayer;
    public GameObject[] _hpIcons;
    
    private Quaternion _rotateDragon;
    private Quaternion _rotateDragon2;

    private Animation _animation;
    private Rigidbody _playerRb;

    private ColliderScript _colliderScript;

    private EnemyScript _enemyScript;
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        _colliderScript = GameObject.Find("Player").GetComponent<ColliderScript>();
        _enemyScript = GetComponent<EnemyScript>();
        _animation = GetComponent<Animation>();
    }

    private void Update()
    {
        
        Move();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rotate();
        Die();
       
    }

    private void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime));
      
    }

    private void Rotate()
    {
        _rotateDragon = new Quaternion(0, 0, -25, 0);
        _rotateDragon2 = new Quaternion(0, 0, 25, 0);
        
        if (horizontalInput > 0 && _rotateDragon != _player.transform.rotation)
        {
            transform.Rotate(0, 0, -1);
        }
        else if (horizontalInput < 0 && _rotateDragon2 != _player.transform.rotation)
        {
            transform.Rotate(0, 0, 1);
        }
    }

    private void Die()
    {
        if (_colliderScript._gameOver == true)
        {
            _animation.Play("sj001_die");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyBullet") || other.CompareTag("Enemy"))
        {
            PlayerHit();
        }
    }

    public void PlayerHit()
    {
        _hpPlayer--;
        Destroy(_hpIcons[_hpPlayer]);
    }
}
