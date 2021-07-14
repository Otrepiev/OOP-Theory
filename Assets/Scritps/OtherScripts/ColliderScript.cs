using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public bool _gameOver;
    private PlayerMove _playerMove;
    void Start()
    {
        _gameOver = false;
        _playerMove = GameObject.Find("Player").GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerMove._hpPlayer == 0)
        {
            _gameOver = true;
            Debug.Log("Игра окончена");
        }
    }

}
