using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] string itemName;

    void OnTriggerEnter(Collider other)
    {
        Managers.Inventory.AddItem(itemName);
        Debug.Log($"Item collected: {itemName}");
        Destroy(this.gameObject);
    }
}
