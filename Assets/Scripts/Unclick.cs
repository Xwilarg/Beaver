using UnityEngine;

public class Unclick : MonoBehaviour
{
    private GameManager gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnMouseDown()
    {
        gm.SetField(null);
    }
}
