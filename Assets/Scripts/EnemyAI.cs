using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public Transform player; // Reference to the player
    public float teleportDistance = 10f; // Maximum teleportation distance
    public float teleportCooldown = 5f; // Time between teleportation attempts
    public float returnCooldown = 10f; // Time before returning to base spot
    [Range(0f, 1f)] public float chaseProbability = 0.65f; // Probability of chasing the player
    public float rotationSpeed = 5f; // Rotation speed when looking at the player
   
    
    private Vector3 baseTeleportSpot;
    private float teleportTimer;
    private bool returningToBase;

    // Ensures the AI starts in the same position + doesn't immediately teleport to the player
    private void Start()
    {
        baseTeleportSpot = transform.position;
        teleportTimer = teleportCooldown;  
    }

    private void Update()
    {
        // No player - return to origin point
        if (player == null)
        {

            return;
        }

        teleportTimer -= Time.deltaTime;


        if (teleportTimer <= 0f)
        {
            // Teleports AI back to origin 
            if (returningToBase)
            {
                TeleportToBaseSpot();
                teleportTimer = returnCooldown;
                returningToBase = false;
            }
            // Triggers AI to teleport
            else
            {
                DecideTeleportAction();
                teleportTimer = teleportCooldown;
            }
        }

        // Controlls the enemy's rotation to the player
        RotateTowardsPlayer();

      
    }

    private void DecideTeleportAction()
    {
        // Causes teleport to be random
        float randomValue = Random.value;

        // If the value is greater/equal to, teleport
        if (randomValue <= chaseProbability)
        {
            TeleportNearPlayer();
        }
        // If not, return to origin
        else
        {
            TeleportToBaseSpot();
        }
    }

    private void TeleportNearPlayer()
    {
        Vector3 randomPosition = player.position + Random.onUnitSphere * teleportDistance;
        randomPosition.y = transform.position.y; // Keep the same Y position
        transform.position = randomPosition;

    }

    private void TeleportToBaseSpot()
    {
        transform.position = baseTeleportSpot;
        returningToBase = true;

       
    }

    // AI Faces the player
    private void RotateTowardsPlayer()
    {
        Vector3 directionToPlayer = player.position - transform.position;
        directionToPlayer.y = 0f; // Ignore the vertical component

        if (directionToPlayer != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}