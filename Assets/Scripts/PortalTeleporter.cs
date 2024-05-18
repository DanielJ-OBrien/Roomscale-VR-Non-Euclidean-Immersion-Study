using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleport : MonoBehaviour
{
    public Transform destinationPortal;
    public float teleportCooldown = 2f;

    private bool canTeleport = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && canTeleport)
        {
            TeleportPlayer(other.transform);
            StartCoroutine(TeleportCooldown());
        }
    }

    private void TeleportPlayer(Transform player)
    {
        // Disable player's collider temporarily to prevent immediate teleportation back
        player.GetComponent<Collider>().enabled = false;

        // Calculate the height and X offset difference between the player and the destination portal
        float heightDifference = player.position.y - transform.position.y;
        float xOffset = player.position.x - transform.position.x;

        // Teleport the player to the destination portal and adjust height and X offset
        player.position = new Vector3(destinationPortal.position.x + xOffset, destinationPortal.position.y + heightDifference, destinationPortal.position.z);

        // Enable player's collider after a short delay
        StartCoroutine(EnableCollider(player.GetComponent<Collider>()));
    }

    private IEnumerator TeleportCooldown()
    {
        canTeleport = false;
        yield return new WaitForSeconds(teleportCooldown);
        canTeleport = true;
    }

    private IEnumerator EnableCollider(Collider collider)
    {
        yield return new WaitForSeconds(0.1f);
        collider.enabled = true;
    }
}


