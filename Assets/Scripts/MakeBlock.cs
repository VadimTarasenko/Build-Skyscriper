using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBlock : MonoBehaviour {

    [HideInInspector]
    public List<GameObject> Blocks;
    public GameObject Block;

    private void Start() {
        Blocks.Add(Instantiate(Block, this.transform));
    }

    private void FixedUpdate() {
        if(Input.GetKeyDown(KeyCode.Space) && (Blocks.Count == 1 || Blocks[Blocks.Count - 2].GetComponent<ManagementBlock>().Builded)) {
            Blocks[Blocks.Count - 1].GetComponent<ManagementBlock>().DropOut();
            Blocks.Add(Instantiate(Block, this.transform));
            GameObject.Find("Score").GetComponent<Score>().IncreaseScore();
            if (Blocks.Count > 3) Camera.main.transform.localPosition = new Vector3(Camera.main.transform.localPosition.x, Blocks[Blocks.Count - 3].transform.localPosition.y + 130.0f, Camera.main.transform.localPosition.z);
        }
    }    
}
