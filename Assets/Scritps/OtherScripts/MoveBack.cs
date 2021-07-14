using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{

    private ColliderScript _scriptCol;

    // Start is called before the first frame update
    void Start()
    {
        _scriptCol = GameObject.Find("Player").GetComponent<ColliderScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_scriptCol._gameOver == false)
        {
            transform.Translate(Vector3.back);
        }
    }
}
