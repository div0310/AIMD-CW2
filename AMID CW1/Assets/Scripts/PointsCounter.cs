using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointsCounter : MonoBehaviour
{
    public int points = 0; // Initial points
    public TMP_Text pointsText; 
   
    public void UpdatePoints()
    {
        points++;
        pointsText.text = points.ToString();
        Debug.Log("Points updated: " + points);
        
    }

    
    public void ReducePoints()
    {
        if (points > 0)
        {
            points--;
            pointsText.text = points.ToString();
            Debug.Log("Points reduced: " + points);
            
        }
    }
}