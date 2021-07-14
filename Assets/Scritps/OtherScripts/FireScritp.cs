using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScritp : MonoBehaviour
{
  [SerializeField]private GameObject _fire;
  [SerializeField]private GameObject _spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    private void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            new WaitForSeconds(1);
            Instantiate(_fire, _spawn.transform.position, Quaternion.identity);
        }
    }
}
