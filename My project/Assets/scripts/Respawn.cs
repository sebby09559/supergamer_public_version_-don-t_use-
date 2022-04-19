using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private TransForm player;
    [SerializeField] private TransForm respawnpoint;

    void OnTriggerEnter(collider other)
    {
        player.TransForm.position = respawnpoint.TransForm.position;
    }
}