using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletRefCount = 0;
    public int bulletRefLimit;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bulletRefLimit == bulletRefCount)
        {
            PhysicMaterial bulletRef = GetComponent<PhysicMaterial>();
            bulletRef.bounciness = 0f;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        bulletRefCount++;        
    }
}
