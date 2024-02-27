using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public float powerTime = 10;
    public bool isPowered = false;

    public Material powerMaterial;
    private Material startMat;

    public void Start(){
        startMat = GetComponent<MeshRenderer>().material;
    }

    public void Update(){
        if (isPowered) {
            GetComponent<MeshRenderer>().material = powerMaterial;
        }
    }

    public void OnTriggerEnter(Collider trigger){
        if(trigger.GetComponent<CollectibleItem>() != null){
            CollectibleItem item = trigger.GetComponent<CollectibleItem>();
            if (item.itemName == "power"){
                isPowered = true;
                StartCoroutine("ResetPower");
            }
        }
    }

    public IEnumerator ResetPower(){
        yield return new WaitForSeconds(powerTime);
        isPowered = false;
        GetComponent<MeshRenderer>().material = startMat;
    }
}
