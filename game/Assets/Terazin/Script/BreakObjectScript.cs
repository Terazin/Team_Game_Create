using Newtonsoft.Json.Converters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakObjectScript : MonoBehaviour
{
    [SerializeField] private GameObject Particle;
    [SerializeField] EnemyDestroy enemyDestroy;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            enemyDestroy.IsBoxDel = true;
            Destroy(gameObject);            
            Instantiate(Particle, this.transform.position, Quaternion.identity);
        }
    }
}
