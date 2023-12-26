using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReserch : MonoBehaviour
{
    [SerializeField] ShotGun shotGun;
    string sceneName;
    public int bulletRefLimit; //�e�X�e�[�W�̔��ˏ���̒�`�i�����̊֌W��A�����+1�����l�����j
    public int bulletRefCount; //���˂����񐔂��i�[
    public bool IsBulletDelete = false;
 
    void Setting(string name)
    {
        switch (name) //���ˉ񐔂̒�`(�����̊֌W��A���ˉ񐔂�+1�����l�ɂȂ��Ă���B)
        {
            case "FirstStage":
                bulletRefLimit = 2;
                break;
            case "SecondStage":
                bulletRefLimit = 5;
                break;
            case "ThirdStage":
                bulletRefLimit = 6;
                break;
            case "FourthStage":
                bulletRefLimit = 3;
                break;
            case "FifthStage":
                bulletRefLimit = 8;
                break;
            case "SixthStage":
                bulletRefLimit = 3;
                break;
            case "SeventhStage":
                bulletRefLimit = 10;
                break;
            case "EighthStage":
                bulletRefLimit = 5;
                break;
            case "NinthStage":
                bulletRefLimit = 11;
                break;
            case "TenthStage":
                bulletRefLimit = 7;
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name; //���݂̃V�[�����̎擾
        Setting(sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        if ((bulletRefLimit != 0) && (bulletRefCount != 0))
        {
            if (bulletRefCount == bulletRefLimit)
            {
                Destroy(shotGun.bulletDel); //�e���������@���v�����Ȃ��������߁A�V�[����ɒe�̃C���X�^���X����邽�߂ɐ錾����GameObject�ϐ����Ăяo���Ă���B
                IsBulletDelete = true;
            }
        }
    }

}
