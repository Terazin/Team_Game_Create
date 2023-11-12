using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Observer : MonoBehaviour
{
    public Transform player;
    public GameObject GameOverWindow;
    private float lockRange = 200;
    bool m_IsPlayerInRange;
    //bool isGamePaused = false; // ÉQÅ[ÉÄÇÃàÍéûí‚é~èÛë‘

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
        if (m_IsPlayerInRange)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position, direction);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit, lockRange)) 
            {
                if (raycastHit.collider.transform == player)
                {
                    GameOverWindow.SetActive(true);
                    SetGamePaused(true); // ÉQÅ[ÉÄÇÃéûä‘Çí‚é~
                    PlayerPrefs.SetInt("IsGamePaused", 1);
                }
            }
        }
    }

    void SetGamePaused(bool isPaused)
    {
        Time.timeScale = isPaused ? 0.0f : 1.0f;
    }
}
