using UnityEngine;

public class Field : MonoBehaviour
{
    private GameManager gm;
    private DebugPannel debug;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        debug = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<DebugPannel>();
    }

    private void OnMouseDown()
    {
        gm.CurrentField = this;
        debug.SetText("Current field: " + name);
    }
}
