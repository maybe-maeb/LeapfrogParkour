using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject shockwave;
    public void OnCollisionEnter(Collision col){
        GameObject shock = Instantiate(shockwave, transform);
        shock.transform.parent = null;
        Destroy(this.gameObject);
    }
}
