using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class Player : MonoBehaviour {
    public float speed = 5f;
 
    public SpriteRenderer mySpriteRenderer;
    Rigidbody2D rb;

    float horizontalValue;
    
    



    Animator animator;



    public GameObject rocks;
  

    public bool onFloor = false;

    public bool p_jump = false;
    
    public bool verticalwalk = false;


    // This function is called just one time by Unity the moment the component loads
    public void Awake()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();

    }

    public void Update()
    {

        ControllPlayer1();
        CheckAxes();
        Animate();

        

        
    }



    void Animate()
    {
        // use the absolute value of horizontal so that "horizontalValue" parameter is
        // only between 0 and +number
        animator.SetFloat("horizontalValue", Mathf.Abs(horizontalValue));

        

    }

    void CheckAxes()
    {
        horizontalValue = Input.GetAxis("Horizontal") * speed;
        
        
        //print(horizontalValue + " - " + verticalValue);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rocks")
        {


            onFloor = true;
            animator.SetBool("p_jump", false);
            Debug.Log("You may now jump.");




        }




        else
        {

            onFloor = false;
            
           


        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        onFloor = false;
        Debug.Log("You shouldn't be able to use jump again.");


    }






    public void ControllPlayer1()
    {
        if (gravity2.Test == true)
        {

            //Controller that is only active starting from the rocks, jumping platforming, on out.


            animator.SetBool("verticalwalk", false);
            
            rb.gravityScale = 0.8f;

            if (onFloor == true && Input.GetKey(KeyCode.W) || onFloor == true && Input.GetKey(KeyCode.UpArrow) || onFloor == true && Input.GetKey(KeyCode.Space))
            {


                animator.SetBool("p_jump", true);

                rb.AddForce(Vector2.up * 5.0f, ForceMode2D.Impulse);

                
                

            }

            if (onFloor == false && Input.GetKey(KeyCode.A) || onFloor == false && Input.GetKey(KeyCode.LeftArrow))
            {


                animator.SetBool("p_jump", true);
                mySpriteRenderer.flipX = false;
                transform.position += Vector3.left * speed * Time.deltaTime;

                //allows player to move midjump to the left. More precise aim for the next rock this way.

            }
            if (onFloor == false && Input.GetKey(KeyCode.D) || onFloor == false && Input.GetKey(KeyCode.RightArrow))
            {
                animator.SetBool("p_jump", true);
                // flip the sprite
                
                mySpriteRenderer.flipX = true;
                transform.position += Vector3.right * speed * Time.deltaTime;

                //allows player to move midjump to the right. More precise aim for the next rock this way.


            }




            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                
                mySpriteRenderer.flipX = false;
                transform.position += Vector3.left * speed * Time.deltaTime;

                

            }




            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                
                // flip the sprite
                
                mySpriteRenderer.flipX = true;
                transform.position += Vector3.right * speed * Time.deltaTime;

               


            }






        }

        if (gravity2.Test == false)
        {
            //controller the player starts out with. This is due to the fact you can move in all directions on the front part of the level.
            onFloor = false;

            animator.SetBool("verticalwalk", false);
            animator.SetBool("p_jump", false);
            

            rb.gravityScale = 0f;
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                animator.SetBool("verticalwalk", true);

                mySpriteRenderer.flipX = false;
                transform.position += Vector3.left * speed * Time.deltaTime;

            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                // flip the sprite
                animator.SetBool("verticalwalk", true);

                mySpriteRenderer.flipX = true;
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                animator.SetBool("verticalwalk", true);

                onFloor = false;
                transform.position += Vector3.up * speed * Time.deltaTime;

            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                animator.SetBool("verticalwalk", true);

                transform.position += Vector3.down * speed * Time.deltaTime;
                

            }

            
        }

    }
}