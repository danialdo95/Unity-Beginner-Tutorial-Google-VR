using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEventManager : MonoBehaviour {

    public static bool GamePlaying;

    [SerializeField]
    Text _scoretext;

    [SerializeField]
    Text _timerText;

    [SerializeField]
    Text _welcomeText;

    [SerializeField]
    Button _startButton;


	// Use this for initialization
	public void Start () {
        GamePlaying = false;
        _scoretext.enabled = false;
        _timerText.enabled = false;
	}

    public void GameStarted()
    {
        GamePlaying = true;

        _welcomeText.enabled = false;
        _startButton.interactable = false;
        _scoretext.enabled = true;
        _timerText.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
