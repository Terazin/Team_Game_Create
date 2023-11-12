using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LockOn : MonoBehaviour
{
    private float lockRange = 250; // 自由に設定
    public Image aimImage;
    private Color originalColor;

    void Start()
    {
        // カーソルを非表示にする。(コントローラでUI選択が出来るようになった後、16行目のコードのコメントを外す。)
        //Cursor.lockState = CursorLockMode.Locked;

        originalColor = aimImage.color;
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        //Debug.DrawRay(ray.origin, ray.direction * 30, Color.red, 30f);

        if (Physics.Raycast(ray, out hit, lockRange)) 
        {
            GameObject target = hit.collider.gameObject;

            if (target.CompareTag("Enemy"))
            {
                // 赤色に変更
                aimImage.color = Color.red;
            }
            else
            {
                aimImage.color = originalColor;
            }
        }
    }
}
