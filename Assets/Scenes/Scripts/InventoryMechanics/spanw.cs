using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spanw : MonoBehaviour
{
    public GameObject item;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    {
        Vector2 playerpos = new Vector2(player.position.x, player.position.y -1);
        Instantiate(item, playerpos, Quaternion.identity);
    }
}
