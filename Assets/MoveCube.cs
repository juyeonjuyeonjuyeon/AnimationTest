using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    Animator animator;
    private Rigidbody rigidbody;
    private BoxCollider collider;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private LayerMask layerMask;

    private bool isMove;
    private bool isJump;
    private bool isFall;


    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        collider = GetComponent<BoxCollider>();
    }

    void Update()
    {
        ToMove();
        ToJump();
    }

    private void ToJump()
    {

        if(isJump)
        {
            if(rigidbody.velocity.y <= -0.1f && !isFall)
            {
                isFall = true;
                animator.SetTrigger("Fall");
            }

            RaycastHit hit;
            if(Physics.Raycast(transform.position, -transform.up, out hit, collider.bounds.extents.y, layerMask))
            {
                animator.SetTrigger("Land");
                isJump = false;
                isFall = false;
            }
        }
        else
        {
            animator.ResetTrigger("Land");
        }

        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            isJump = true;
            //rigidbody.velocity = new Vector3(0, jumpForce, 0);
            rigidbody.AddForce(Vector3.up * jumpForce); 
            animator.SetTrigger("Jump");
        }
    }

    private void ToMove()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        float dirZ = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(dirX, 0, dirZ);

        isMove = false;

        if(direction != Vector3.zero)
        {
            isMove = true;
            this.transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
        }

        animator.SetBool("Move", isMove);
        animator.SetFloat("DirX", direction.x);
        animator.SetFloat("DirZ", direction.z);
    }
}
