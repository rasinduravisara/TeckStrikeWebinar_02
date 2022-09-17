using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Player playerMovement;
    public Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            rb.useGravity = true;
            FindObjectOfType<GameManager>().GameOver();

        }
    }

}
