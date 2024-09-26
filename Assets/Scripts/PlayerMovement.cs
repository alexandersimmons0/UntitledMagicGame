using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    private float hInput;
    private float vInput;

    public float speed;
    public Rigidbody rigid;
    public PlayerInventory inventoryScript;

    void Update(){
        hInput = Input.GetAxis("Horizontal") * speed;
        vInput = Input.GetAxis("Vertical") * speed;
        if(Input.GetKeyDown(KeyCode.E)){
            inventoryScript.DisplayInventory();
        }
    }

    void FixedUpdate(){
        rigid.MovePosition (transform.position + transform.forward * vInput * Time.deltaTime + transform.right * hInput * Time.fixedDeltaTime);
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("collectable")){
            other.gameObject.SetActive(false);
            inventoryScript.CollectObject(other.gameObject);
        }
    }
}
