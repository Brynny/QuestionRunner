using UnityEngine;
using System.Collections;

public class HighScoreEntry
{
	public string playerName;
	public float playerScore;

	public HighScoreEntry (string pN, float pS)
	{
		playerName = pN;
		playerScore = pS;
	}

}
