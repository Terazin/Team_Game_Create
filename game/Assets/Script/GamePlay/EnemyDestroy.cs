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
            animator.SetTrigger("EnemyDeath");//�G�����U����A�j���[�V�����Ăяo��
            source.PlayOneShot(destroySound);
            Destroy(gameObject, 1f);////�G�����U����r���ŏ����Ȃ��悤�ɔ�e���Ă���3�b��ɏ�����悤�ɕύX
            clear.destroyCount++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            animator.SetTrigger("EnemyDeath");//�G�����U����A�j���[�V�����Ăяo��
            source.PlayOneShot(destroySound);
            Destroy(gameObject,1f);////�G�����U����r���ŏ����Ȃ��悤�ɔ�e���Ă���3�b��ɏ�����悤�ɕύX
            clear.destroyCount++;
        }
    }
}
