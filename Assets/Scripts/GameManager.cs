using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } // Shortcut for checking

    private Vector3 currentCheckpointPosition;

    private void Awake() // Set up check point
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateCheckpoint(Vector3 newCheckpointPosition) // Update with new pos
    {
        currentCheckpointPosition = newCheckpointPosition;
    }

    public Vector3 GetCurrentCheckpointPosition() // Get last check points
    {
        return currentCheckpointPosition;
    }
}
