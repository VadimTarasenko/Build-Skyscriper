using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private Text Text;

    private void Start() {
        Text = this.GetComponent<Text>();
        Text.text = "0";
    }

    public void IncreaseScore() {
        int PrimeScore = System.Convert.ToInt32(Text.text);
        Text.text = System.Convert.ToString(PrimeScore + 100);
    }

    private void FixedUpdate() {
        this.transform.localPosition = new Vector3(this.transform.localPosition.x, Camera.main.transform.localPosition.y, -10.0f);
    }
}
