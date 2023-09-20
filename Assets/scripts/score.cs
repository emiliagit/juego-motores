using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText; // Referencia al componente Text que mostrará el puntaje.
    private int puntuacion = 0; // Puntaje actual.

    private void Start()
    {
        UpdateScoreText();
    }

    public void AddScore(int pointsToAdd)
    {
        puntuacion += pointsToAdd;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "PUNTAJE: " + puntuacion.ToString();
        }
    }
}
