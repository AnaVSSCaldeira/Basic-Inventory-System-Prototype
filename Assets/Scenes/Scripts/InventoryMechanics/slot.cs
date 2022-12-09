using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot : MonoBehaviour
{
    private inventorySystem inventory;
    public int i;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventorySystem>();
    }

    void Update()
    {
        if(transform.childCount <= 0)
        {
            inventory.isFull[i] = false;
        }
    }
    

    public void DropItem()
    {
        foreach(Transform child in transform)
        {
            child.GetComponent<spanw>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);
        }
    }
}
