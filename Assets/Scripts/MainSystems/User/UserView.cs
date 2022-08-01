using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserView : MonoBehaviour
{
    Animator animator;
    [SerializeField] private GameObject charactor;

    void Start()
    {
        animator = charactor.GetComponent<Animator>();
    }

    public void CharactorJump()
    {
        animator.SetTrigger("IsJumpIn");
    }
}
