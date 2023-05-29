using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int score;
	public Text scoreText;


	public void IncreaseScore(int points)
	{
		score += points;
		scoreText.text = score.ToString();
	}

	public void OnBombHit()
	{
		Time.timeScale = 0;
	}
}
