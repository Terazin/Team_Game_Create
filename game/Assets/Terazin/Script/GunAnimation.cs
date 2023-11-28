using UnityEngine;

public class GunAnimation : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
     void Update()
     {
      // �R���g���[���[��RT�{�^���ł̓��͂��擾
      bool isTriggerPressed = Input.GetAxis("TriggerRight") > 0.1f;
            if (isTriggerPressed)  
            {
                animator.SetBool("GunFire", true);
            }
        }
}
