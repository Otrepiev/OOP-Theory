using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanelScript : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;
    private ColliderScript _colliderScript;
    // Start is called before the first frame update
    void Start()
    {
        _colliderScript = GameObject.Find("Player").GetComponent<ColliderScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_colliderScript._gameOver == true)
        {
            _canvas.SetActive(true);
        }
    }
}
