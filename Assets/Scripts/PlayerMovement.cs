using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    private float hInput;
    private float vInput;

    public float speed;
    public Rigidbody rigid;

    void Update(){
        hInput = Input.GetAxis("Horizontal") * speed;
        vInput = Input.GetAxis("Vertical") * speed;
    }

    void FixedUpdate(){
        rigid.MovePosition (transform.position + transform.forward * vInput * Time.deltaTime + transform.right * hInput * Time.fixedDeltaTime);
    }
}
