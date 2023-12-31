using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Imageコンポーネントを使用するために追加
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Observer : MonoBehaviour
{
    public Transform player;
    public GameObject GameOverWindow;
    public Image canvasImage; // キャンバス上のImageコンポーネント
    public Image canvasImage2;
    public Image canvasImage3;
    private float lockRange = 200;
    private bool m_IsPlayerInRange;
    private bool isCooldown = false; // 検知のクールダウン状態
    private int detectionCount = 0; // プレイヤーが検知された回数
    private int maxDetectionCount = 3; // ゲームオーバーになる検知の最大回数
    private float cooldownDuration = 2.0f; // 次の検知までのクールダウン時間

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = false;
        }
    }

    void Update()
    {
        if (m_IsPlayerInRange && !isCooldown)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position, direction);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit, lockRange))
            {
                if (raycastHit.collider.transform == player)
                {
                    detectionCount++; // プレイヤーが検知された回数を増やす
                    Debug.Log("見つけたよ");

                    // キャンバス上のImageコンポーネントの色を変更する
                    if (canvasImage != null)
                    {
                        canvasImage.color = Color.red; // 例として赤色に変更
                    }

                    if (detectionCount >= maxDetectionCount)
                    {
                        GameOverWindow.SetActive(true);
                        SetGamePaused(true); // ゲームの時間を停止
                        PlayerPrefs.SetInt("IsGamePaused", 1);
                    }

                    StartCooldown(); // クールダウンを開始
                }
            }
        }


        if (detectionCount == 2)
        {
            canvasImage2.color = Color.red;
        }

        if (detectionCount == 3)
        {
            canvasImage3.color = Color.red;
        }

        if (isCooldown)
        {
            cooldownDuration -= Time.deltaTime;
            if (cooldownDuration <= 0)
            {
                isCooldown = false;
                cooldownDuration = 2.0f; // クールダウン時間をリセット

                
            }
        }
    }



    void SetGamePaused(bool isPaused)
    {
        Time.timeScale = isPaused ? 0.0f : 1.0f;
    }

    void StartCooldown()
    {
        isCooldown = true;
    }
}
