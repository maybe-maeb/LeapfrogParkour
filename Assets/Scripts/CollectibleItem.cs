using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public string itemName;

    void OnTriggerEnter(Collider other) {
        Debug.Log($"Item collected: {itemName}");
        Destroy(this.gameObject);
    }
}
