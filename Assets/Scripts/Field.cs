using UnityEngine;

public class Field : MonoBehaviour
{
    private GameManager gm;
    private DebugPannel debug;
    public enum STATE { NONE, OCCUPIED, WIP, DONE, ERROR, SIZE};
    public STATE currentState { get; private set; }

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        debug = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<DebugPannel>();
    }

    private void OnMouseDown()
    {
        gm.SetField(this);
        debug.SetText("Current field: " + name);
    }
}
