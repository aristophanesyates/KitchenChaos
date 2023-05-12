using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APlayerAnimator : MonoBehaviour
{
    private const string IS_WALKING = "IsWalking";
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private APlayer player;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
