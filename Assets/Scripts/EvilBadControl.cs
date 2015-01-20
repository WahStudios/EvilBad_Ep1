using UnityEngine;
using System.Collections;

public class EvilBadControl : MonoBehaviour {

    public float speedForce = 20;           //Evil Bad's Forward Speed
    public Vector2 jumpVector;              //Evil Bad's jump position (x,y) ex: if x=0, then jump straight up, if x=0.5 slight right etc..
    public bool isGrounded;                 //ground switch, handled by ground check function
    public Transform grounder;              //object that checks for the ground, child of Evil Bad
    public float radiuss = 0.2f;            //radius check for ground
    public LayerMask ground;                //what is considered ground? assign layers
    public bool isFalling;                  //falling switch, for animation purposes
    public Animator anim;                   //Evil Bad's Animator
    public bool jump;                       //jump switch, for animations
    public Rigidbody2D rigid;               //Evil Bad's RigidBody2D = interacts with physics
    public bool stabStand = false;          //switch for anims
    public bool shieldStand = false;        //^^  ^^
    public bool isSnapped = false;
    public GameObject snapObject;
	public tabManager Tabmanager;
	public ParticleSystem fireBall;
	public ParticleSystem fireBallLeft;
	public bool fireBallActive = true;
	public bool isFacingRight = true;
	// Use this for initialization
    private void Awake()
    {
        // Setting up references.
        
        anim = GetComponent<Animator>();
    }
    
    void Start () {
		fireBall.emissionRate = 0;
        jump = anim.GetBool("jump");
        rigid = GetComponent<Rigidbody2D>();
	
	}
        
	// Update is called once per frame
	void Update () {

		if(Tabmanager.isActive == false){
        // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
        isGrounded = Physics2D.OverlapCircle(grounder.transform.position, radiuss, ground);
        anim.SetBool("isGrounded", isGrounded);
        if(Input.GetButtonDown("Snap") && isGrounded == true)
        {
            if (isSnapped == false)
                isSnapped = true;
            else
                isSnapped = false;
        }

        if (isSnapped == true)
        {
            snapObject.SetActive(true);
            rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
            anim.SetBool("walk", false);
            anim.SetBool("walkToIdle", true);
        }
              
        else if (isSnapped == false)
        {
            snapObject.SetActive(false);
            if (Input.GetButton("Jump") && isGrounded == true)
            {
                rigidbody2D.AddForce(jumpVector, ForceMode2D.Force);
            }
            if (Input.GetAxis("Horizontal") < 0)
            {
                if (shieldStand == false)
                {
						isFacingRight = true;
                    rigidbody2D.velocity = new Vector2(-speedForce, rigidbody2D.velocity.y);
                }
                transform.localScale = new Vector3(1, 1, 1);

            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                if (shieldStand == false)
                {
						isFacingRight = false;
                    rigidbody2D.velocity = new Vector2(speedForce, rigidbody2D.velocity.y);
                }
                transform.localScale = new Vector3(-1, 1, 1);

            }
            else
            {
                rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
            }


            if (rigid.velocity.y == 0)
            {
                isFalling = false;
                anim.SetBool("jump", false);
                anim.SetBool("jumpForward", false);
                anim.SetBool("isFalling", false);
            }
            else
                if (rigid.velocity.y < -1)
                {
                    isFalling = true;
                    anim.SetBool("isFalling", isFalling);
                    anim.SetBool("jump", false);
                    anim.SetBool("jumpForward", false);

                }
                else
                    if (rigid.velocity.y > 1)
                    {
                        isFalling = false;
                        anim.SetBool("jump", true);
                        anim.SetBool("isFalling", false);
                    }
            //if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)//forward or backward
            if (rigid.velocity.x > 0 || rigid.velocity.x < 0)
            {
                //jump = anim.GetBool("jump");
                // isGrounded = anim.GetBool("isGrounded");
                //if (jump == false)
                //{
                if (isGrounded == true)
                {
                    anim.SetBool("walk", true);
                    anim.SetBool("jumpForward", false);
                    anim.SetBool("walkToIdle", false);
                }
                //}
                else //if (jump == true)
                    //{
                    if (isGrounded == false)
                    {
                        anim.SetBool("jumpForward", true);
                        anim.SetBool("jump", false);
                        anim.SetBool("walk", false);
                        anim.SetBool("walkToIdle", false);
                    }

                //}
            }
            else if (rigid.velocity.x == 0) //not in use
            {
                anim.SetBool("walk", false);
                anim.SetBool("jumpForward", false);
                anim.SetBool("walkToIdle", true);
            }

            if (Input.GetButtonDown("Fire1"))
            //if(Input.GetMouseButton(0))
            {
				if(fireBallActive == true)
					{
						if(isFacingRight == false){
						CancelInvoke ("KillFireBall");
						fireBall.emissionRate = 1;
						Invoke ("KillFireBall", 1f);
						}
						else
						{
							CancelInvoke ("KillFireBall");
							fireBallLeft.emissionRate = 1;
							Invoke ("KillFireBall", 1f);

						}
					}
					else{
						fireBall.emissionRate = 0;
						fireBallLeft.emissionRate = 0;
					}
						
                if (isGrounded == true)
                {
                    anim.SetTrigger("stab");
                }
                else
                {
                    anim.SetTrigger("stabJump");
                }
            }




            if (Input.GetButtonDown("Fire3"))
            {
                shieldStand = !shieldStand;

            }


            if (rigid.velocity.y == 0)
            {
                if (shieldStand == true)
                {
                    anim.SetBool("shieldStand", true);
                    anim.SetBool("shieldJump", false);
                }
                //else
                //  anim.SetBool("shieldStand", false);
            }


            ///below should be used after shieldJump anim is done
            if (rigid.velocity.y > 1)
            {
                if (shieldStand == true)
                {
                    anim.SetBool("shieldStand", false);
                    //                anim.SetBool("shieldJump", true);
                    shieldStand = false;
                }
            }

            if (shieldStand == false)
            {
                anim.SetBool("shieldJump", false);
                anim.SetBool("shieldStand", false);
            }

            //if(Input.GetButtonUp("Fire1"))
            //if(Input.GetMouseButtonUp(0))
            //{
            //  anim.SetT("stab", false);
            //anim.SetTrigger("stabjum");
            //}
            //
        }
		}
		else{
			rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
			anim.SetBool("walk", false);
			anim.SetBool("walkToIdle", true);
		}
        
	}

	void KillFireBall()
	{
		fireBall.emissionRate = 0;
		fireBallLeft.emissionRate = 0;
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(grounder.transform.position, radiuss);
    }

}
