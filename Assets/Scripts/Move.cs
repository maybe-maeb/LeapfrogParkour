using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public bool playerOne;
    public float moveSpeed = 5;
    public float jumpForce = 750;
    private bool grounded;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerOne)
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                float h = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;

                this.transform.Translate(-h, 0, 0);
            }
            if (Input.GetAxis("Vertical") > 0) this.transform.Translate(0, 0, -Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime);

            if (grounded)
            {
                if (Input.GetAxis("Jump") > 0)
                {
                    GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 0) * jumpForce);
                    grounded = false;
                }
            }
        }
        else if (playerOne == false)
        {
            if (Input.GetAxis("Horizontal2") != 0)
            {
                float h = Input.GetAxisRaw("Horizontal2") * moveSpeed * Time.deltaTime;

                this.transform.Translate(-h, 0, 0);
            }
            if (Input.GetAxis("Vertical2") > 0) this.transform.Translate(0, 0, -Input.GetAxisRaw("Vertical2") * moveSpeed * Time.deltaTime);

            if (grounded)
            {
                if (Input.GetAxis("Jump2") > 0)
                {
                    GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 0) * jumpForce);
                    grounded = false;
                }
            }
        }

    }

    public void OnCollisionEnter(Collision col)
    {
        grounded = true;
    }
}
