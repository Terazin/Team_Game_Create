using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    private Animator animator;
    [SerializeField] Clear clear;
    [SerializeField] AudioSource audioSource;
    public AudioClip destroySound;
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
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            animator.SetTrigger("EnemyDeath");//“G‚ª”šU‚·‚éƒAƒjƒ[ƒVƒ‡ƒ“ŒÄ‚Ño‚µ
            source.PlayOneShot(destroySound);
            Destroy(gameObject,1f);////“G‚ª”šU‚·‚é“r’†‚ÅÁ‚¦‚È‚¢‚æ‚¤‚É”í’e‚µ‚Ä‚©‚ç3•bŒã‚ÉÁ‚¦‚é‚æ‚¤‚É•ÏX
            clear.destroyCount++;
        }
    }
}
