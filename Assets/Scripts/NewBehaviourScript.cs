using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{

    public float Speed;
    public float JumpForce;
    private Rigidbody2D rig;

    private bool isFalling;

    private Animator anim;

    public bool IsJumping;

    public bool dobleJumping;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Move();
        jump();
        IsFalling();
    }

    void Move(){

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;
        if(Input.GetAxis("Horizontal") > 0f){
        anim.SetBool("walk",true);
        transform.eulerAngles = new Vector3(0f,0f,0f);}
        
        if(Input.GetAxis("Horizontal") < 0f){
        anim.SetBool("walk",true);
        transform.eulerAngles = new Vector3(0f,180f,0f);}
       
        if(Input.GetAxis("Horizontal") == 0){
        anim.SetBool("walk",false);}

    }

    void jump(){

        if(Input.GetButtonDown("Jump")){

            if(!IsJumping){
                 rig.AddForce(new Vector2(0f,JumpForce), ForceMode2D.Impulse);
                 dobleJumping = true;
                 anim.SetBool("jump",true);
            }

           else{
            if (dobleJumping){
                 rig.AddForce(new Vector2(0f,JumpForce), ForceMode2D.Impulse);
                 dobleJumping = false;
            }
           }
        }
    }

    void IsFalling(){
        isFalling = rig.linearVelocity.y < 0 && IsJumping; 
        anim.SetBool("fall", isFalling);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8){
            IsJumping = false;
            anim.SetBool("jump",false);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8){
        IsJumping = true;
        anim.SetBool("fall",true); }
    }
}
