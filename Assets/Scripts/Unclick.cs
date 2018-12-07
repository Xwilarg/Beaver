using UnityEngine;

public class Unclick : MonoBehaviour
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
        gm.SetField(null);
        debug.SetText("");
    }
}
