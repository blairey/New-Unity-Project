using UnityEngine;
using System.Collections;

public class AlanController : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;

    public bool GroundedToPlatform;
    public LayerMask ground ;
    private Collider2D alansCollider;

    private Rigidbody2D AlansBody;

    private Animator alanAnimator;

	// Use this for initialization
	void Start () {

        AlansBody = GetComponent<Rigidbody2D>();

        alansCollider = GetComponent<Collider2D>();

        alanAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        AlansBody.velocity = new Vector2(moveSpeed, AlansBody.velocity.y);

        GroundedToPlatform = Physics2D.IsTouchingLayers(alansCollider, ground);

        if (GroundedToPlatform)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                AlansBody.velocity = new Vector2(AlansBody.velocity.x, jumpForce);
            }
        }

        alanAnimator.SetFloat("speed", AlansBody.velocity.x);
        alanAnimator.SetBool("groundedToPlatform", GroundedToPlatform);
	}
}
