using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider col){
        if (col.transform.CompareTag("Player")){
            Vector3 newPos = col.transform.localPosition;
            newPos = new Vector3(newPos.x, newPos.y, 8f);
            col.transform.localPosition = newPos;
        }
    }
}
