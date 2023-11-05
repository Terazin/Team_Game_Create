using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletRefCount ;
    [SerializeField] SceneReserch sceneReserch;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionStay(Collision collision)
    {
        bulletRefCount++;
        sceneReserch.bulletCount = bulletRefCount;
    }
}
