using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    private Animator animator;
    [SerializeField] Clear clear;
    [SerializeField] AudioSource audioSource;
    public AudioClip destroySound;
    public bool IsBoxDel;
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        source = audioSource.GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (IsBoxDel)
        {
            animator.SetTrigger("EnemyDeath");//敵が爆散するアニメーション呼び出し
            source.PlayOneShot(destroySound);
            Destroy(gameObject, 1f);////敵が爆散する途中で消えないように被弾してから3秒後に消えるように変更
            clear.destroyCount++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            animator.SetTrigger("EnemyDeath");//敵が爆散するアニメーション呼び出し
            source.PlayOneShot(destroySound);
            Destroy(gameObject,1f);////敵が爆散する途中で消えないように被弾してから3秒後に消えるように変更
            clear.destroyCount++;
        }
    }
}
