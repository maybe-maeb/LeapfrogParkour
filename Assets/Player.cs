using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public bool isPlayerOne;
    public GameObject projectile;
    public float throwForce;

    public void Update(){
        if (isPlayerOne && Input.GetButtonDown("Fire1")) Shoot();
        if (!isPlayerOne && Input.GetButtonDown("Fire2")) Shoot();

        if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Die(){
        GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>().Win(isPlayerOne);
        Destroy(this.gameObject);
    }

    public void Shoot(){
        GameObject shotProj = Instantiate(projectile, transform);
        shotProj.transform.parent = null;
        Vector3 moveDir = GetComponent<Rigidbody>().velocity;
        moveDir = new Vector3(moveDir.x, 0, moveDir.z);
        moveDir.Normalize();
        shotProj.GetComponent<Rigidbody>().AddForce(moveDir * throwForce);
    }
}
