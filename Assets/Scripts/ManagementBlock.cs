using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagementBlock : MonoBehaviour {

    public GameObject GameOverLayer;
    public float Speed = 10.0f;
    // 1 - right, -1 - left, 0 - stay
    [HideInInspector] public int Move = 1;
    [HideInInspector] public bool Builded;

    private void Start() {
        Builded = false;
        this.transform.localPosition = new Vector3(Camera.main.transform.localPosition.x - 574.0f, Camera.main.transform.localPosition.y + 320.0f, -10.0f);
        this.GetComponent<Rigidbody2D>().simulated = false;
    }

    private void FixedUpdate() {
        if (Move == 1) {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x + Speed, 320.0f + Camera.main.transform.localPosition.y, this.transform.localPosition.z);
        }
        if (Move == -1) {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x - Speed, 320.0f + Camera.main.transform.localPosition.y, this.transform.localPosition.z);
        }

        CheckPosition();
    }

    private void OnCollisionEnter2D(Collision2D CollisionObj) { 
        if(CollisionObj.transform.name == "BuildPlace") {
            Time.timeScale = 0.0f;
            Instantiate(GameOverLayer, (new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, this.transform.position.z)), Quaternion.identity, GameObject.Find("MainCanvas").transform);
            print("Game over");
        } else {
            this.GetComponent<AudioSource>().Play();
            Builded = true;
        }
    }

    private void CheckPosition() {
        if (this.transform.localPosition.x < -574.0f) {
            Move = 1;
        }
        else if (this.transform.localPosition.x > 574.0f) {
            Move = -1;
        }
    }

    public void DropOut() {
        Move = 0;
        this.GetComponent<Rigidbody2D>().simulated = true;
    }
}
