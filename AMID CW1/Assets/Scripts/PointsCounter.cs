using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointsCounter : MonoBehaviour
{
    public int points = 0; // Initial points
    public TMP_Text pointsText; // Reference to the UI Text component

    // Call this method whenever you want to update points
    public void UpdatePoints()
    {
        points++;
        pointsText.text = points.ToString();
        Debug.Log("Points updated: " + points);
        // You can perform additional actions here based on the updated points
    }
}