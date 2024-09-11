using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour{

    // required behaviours: spawn, wander, attack, die
    public int health;
    public Renderer rend;

    void Update(){
        if(health <= 0){
            Die();
        }
    }

    public void TakeDamage(string spellType, int damageTaken){
        health -= damageTaken;
    }

    void Die(){
        Debug.Log("dead");
    }
}
