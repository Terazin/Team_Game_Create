using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    private Animator animator;
    [SerializeField] Clear clear;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            animator.SetTrigger("EnemyDeath");//敵が爆散するアニメーション呼び出し
            Destroy(gameObject,1f);////敵が爆散する途中で消えないように被弾してから3秒後に消えるように変更
            clear.destroyCount++;
        }
    }
}
