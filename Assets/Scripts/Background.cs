using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    private void Update() {
        this.transform.localPosition = new Vector3(this.transform.localPosition.x, Camera.main.transform.localPosition.y, this.transform.localPosition.z);
    }
}
