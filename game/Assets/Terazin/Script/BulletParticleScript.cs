using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletParticleScript : MonoBehaviour
{
    public ParticleSystem BulletParticle;
    private Vector3 lastDirection;
    // Start is called before the first frame update
    void Start()
    {
        // 初期方向を保存
        lastDirection = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentDirection = transform.forward;

        // 方向が変わったかどうかをチェック
        if (currentDirection != lastDirection)
        {
            // パーティクルシステムの方向を更新
            var shape = BulletParticle.shape;
            shape.rotation = Quaternion.LookRotation(currentDirection).eulerAngles;

            // 最後の方向を更新
            lastDirection = currentDirection;
        }
    }
}
