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
	public ObjectPool objectPool;
	public float fireRate = 1;
	int n = 0;

	private float nextFire;

    private void Awake()
    {
      
        anim = GetComponent<Animator>();
    }
    
    void Start () {
		fireBall.emissionRate = 0;
        jump = anim.GetBool("jump");
        rigid = GetComponent<Rigidbody2D>();
	
	}
	public bool jumpButton = false;    
	public bool jumpStop = false;
	public bool jumpFall = false;
	public bool shieldUp = false;
	public bool snapping = false;
	public bool tabManager = false;
	public bool walking = false;
	// Update is called once per frame
	void Update () {

		if(Tabmanager.isActive == false){
			tabManager = false;
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
			if(snapping == false){
            snapObject.SetActive(true);
            rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
					if(anim.GetBool("walk") == true)
			anim.SetBool("walk", false);
					if(anim.GetBool("walkToIdle") ==false)
            anim.SetBool("walkToIdle", true);
					snapping = true;	
				}

        }
              
        else if (isSnapped == false)
        {
			if(snapping == true){
			snapping = false;
			snapObject.SetActive(false);
				}

          
            if (Input.GetButton("Jump") && isGrounded == true)
            {
				jumpButton = false;
				if(jumpButton == false){
                rigidbody2D.AddForce(jumpVector, ForceMode2D.Force);
				jumpButton = true;
				}
				
            }
            if (Input.GetAxis("Horizontal") < 0)
            {
					if(anim.GetBool("duck") == false){
           
						isFacingRight = true;
                    rigidbody2D.velocity = new Vector2(-speedForce, rigidbody2D.velocity.y);
           
                transform.localScale = new Vector3(1, 1, 1);
					}

            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
					if(anim.GetBool("duck")== false){
						isFacingRight = false;
                    rigidbody2D.velocity = new Vector2(speedForce, rigidbody2D.velocity.y);
          
                transform.localScale = new Vector3(-1, 1, 1);

					}
					}
            else
            {
                rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
            }


            if (rigid.velocity.y == 0)
            {

			
				if(anim.GetBool("jump") == true)
                anim.SetBool("jump", false);
				if(anim.GetBool("jumpForward") == true)
                anim.SetBool("jumpForward", false);
				if(anim.GetBool("isFalling")== true)
                anim.SetBool("isFalling", false);
			
            }
            else
                if (rigid.velocity.y < -1)
                {
                    if(anim.GetBool("isFalling") == false)
					anim.SetBool("isFalling", true);
                    if(anim.GetBool("jump") == false)
					anim.SetBool("jump", true);
					if(anim.GetBool("jumpForward") == true)
                    anim.SetBool("jumpForward", false);
						//jumpFall = true;
						//jumpStop = false;
					//}

                }
                else
                    if (rigid.velocity.y > 1)
                    {

					if(anim.GetBool("jump") == false)
					anim.SetBool("jump", true);
					if(anim.GetBool("isFalling")== true)
                        anim.SetBool("isFalling", false);

                    }
     
            if (rigid.velocity.x > 0 || rigid.velocity.x < 0)
            {
             
                if (isGrounded == true)
                {
						if(anim.GetBool("walk") == false)
                    anim.SetBool("walk", true);
						if(anim.GetBool("jumpForward") == true)
                    anim.SetBool("jumpForward", false);
						if(anim.GetBool("walkToIdle") == true)
							anim.SetBool("walkToIdle", false);
				//			walking = false;
				//		}
                }
                //}
                else //if (jump == true)
                    //{
                    if (isGrounded == false)
                    {
				//		if(walking == true){
						if(anim.GetBool("jumpForward")== false)
                        anim.SetBool("jumpForward", true);
						if(anim.GetBool("jump") == true)
                        anim.SetBool("jump", false);
						if(anim.GetBool("walk")== true)
						anim.SetBool("walk", false);
						if(anim.GetBool("walkToIdle") == true)
                        anim.SetBool("walkToIdle", false);
				//			walking = false;
				//		}
                    }

                //}
            }
            else if (rigid.velocity.x == 0) //not in use
            {
				//if(walking == false){
					if(anim.GetBool("walk")== true)
                anim.SetBool("walk", false);
					if(anim.GetBool("jumpForward")== true)
                anim.SetBool("jumpForward", false);
					if(anim.GetBool("walkToIdle")== false)
                anim.SetBool("walkToIdle", true);
				//		walking = true;

			if(Input.GetAxis("Vertical")< 0)
					{
						if(anim.GetBool("duck") == false)
							anim.SetBool("duck", true);
					}
			else
					{
						if(anim.GetBool("duck") == true)
							anim.SetBool("duck", false);
					}
				//	}
            }

            if (Input.GetButtonDown("Fire1"))
            //if(Input.GetMouseButton(0))
            {
					if(anim.GetBool("shieldStand") == false){
				if(fireBallActive == true)
					{

						if (Time.time > nextFire) {
								nextFire = Time.time + objectPool.fireBallFireRate;
								if(n < objectPool.fireBallMaxNumber)
									n = n + 1;
								else if(n == objectPool.fireBallMaxNumber)
									n = 0;
								objectPool.fireBallList[n].transform.position = transform.position;

							if(isFacingRight == true){
										objectPool.fireBallMovement[n].FireLeft ();

							}
							else 
							{
								objectPool.fireBallMovement[n].FireRight ();
							}
						}
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
            }




            if (Input.GetButtonDown("Fire3"))
            {
                shieldStand = !shieldStand;

            }


                if (shieldStand == true)
                {
	
					if(anim.GetBool("shieldStand")== false)
                    anim.SetBool("shieldStand", true);

					}

                }


            if (shieldStand == false)
            {

				if(anim.GetBool("shieldStand") == true)
                anim.SetBool("shieldStand", false);
			
					}
            }

  
		else{
		
			rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
			anim.SetBool("walk", false);
			anim.SetBool("walkToIdle", true);
			
		}
        
	}


	
    void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(grounder.transform.position, radiuss);
    }

}
