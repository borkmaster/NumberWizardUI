using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 10;

	public Text guessText;

	void Start () {
		StartGame ();
	}

	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;

		max += 1;
		guessText.text = "Is your number: " + guess.ToString() + "?";
	}

	void NextGuess () {
		guess = (max + min) / 2;
		guessText.text = "Is your number: " + guess.ToString() + "?";
		maxGuessesAllowed -= 1;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}

	public void GuessHigher() {
		min = guess;
		NextGuess ();
	}

	public void GuessLower() {
		max = guess;
		NextGuess ();
	}

}
