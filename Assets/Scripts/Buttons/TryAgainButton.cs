using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryAgainButton : MonoBehaviour {

	public void TryAgain() {
        Time.timeScale = 1.0f;
        Application.LoadLevel("GameProcess");
    }
}
