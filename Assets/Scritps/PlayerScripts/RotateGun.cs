using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGun : MonoBehaviour
{
    [SerializeField] private GameObject _gun1;
    [SerializeField] private GameObject _gun2;
    [SerializeField] private GameObject _gun3;
    

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _gun1.transform.Rotate(0,0.2f,0);
        _gun2.transform.Rotate(0,0.2f,0);
        _gun3.transform.Rotate(0,-0.2f,0);
    }
}
