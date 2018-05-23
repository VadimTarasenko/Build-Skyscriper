using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverLayer : MonoBehaviour {

    public Text Score;

	// Use this for initialization
	void Start () {
        Score.text = "Your score = " + GameObject.Find("Score").GetComponent<Text>().text;
	}
}
