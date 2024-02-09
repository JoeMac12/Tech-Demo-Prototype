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

    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene for now
    }
}
