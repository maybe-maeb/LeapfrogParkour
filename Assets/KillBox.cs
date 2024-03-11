using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    void OnCollisionEnter(Collision col){
        if (col.transform.CompareTag("Player")){
            Player p = col.transform.GetComponent<Player>();
            p.Die();
            Debug.Log("Player died!");
        }
    }
}
