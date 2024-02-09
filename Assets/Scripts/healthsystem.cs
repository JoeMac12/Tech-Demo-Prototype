using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class healthsystem : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public TextMeshProUGUI healthDisplay;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthDisplay();
        transform.position = GameManager.Instance.GetCurrentCheckpointPosition();
    }

    public void TakeDamage(int damage) // Simple take damage for kill boxes
    {
        currentHealth -= damage;
        UpdateHealthDisplay();
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void UpdateHealthDisplay()
    {
        healthDisplay.text = "Health: " + currentHealth; // Display the health
    }

    void Die() // Kill the player and respawn at last checkpoint
    {
        transform.position = GameManager.Instance.GetCurrentCheckpointPosition();
        currentHealth = maxHealth;
        UpdateHealthDisplay();
    }
}
