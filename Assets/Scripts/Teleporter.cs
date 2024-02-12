using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    public Vector3 targetPosition;

    public void OnTriggerEnter(Collider col){
        if (col.transform.CompareTag("Player")){
            col.transform.localPosition = targetPosition;
        }
    }
}
