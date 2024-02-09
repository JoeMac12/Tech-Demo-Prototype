using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    public Transform teleportDestination;

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportDestination.position; // Teleport whatever enters the trigger to the destination
    }
}
