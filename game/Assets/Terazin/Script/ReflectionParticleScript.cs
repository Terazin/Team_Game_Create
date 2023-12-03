using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectionParticleScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private ParticleSystem particle;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged")
        {
            // パーティクルシステムのインスタンスを生成する。
            ParticleSystem newParticle = Instantiate(particle);
            // パーティクルの発生場所をこのスクリプトをアタッチしているGameObjectの場所にする。
            newParticle.transform.position = this.transform.position;
            // パーティクルを発生させる。
            newParticle.Play();
            Destroy(newParticle.gameObject, 5.0f);
        }
    }
}
