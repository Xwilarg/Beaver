using UnityEngine;

public class Field : MonoBehaviour
{
    private GameManager gm;
    public enum STATE { NONE, OCCUPIED, WIP, DONE, ERROR, SIZE};
    public STATE currentState { get; private set; }

    [SerializeField]
    private Material CantDo, CanDo, Done;

    private enum Status
    {
        CantDo,
        CanDo,
        Done
    }

    [SerializeField]
    private Db.Work neededWork;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        if (gm.work == neededWork)
            GetComponent<MeshRenderer>().material = CanDo;
        else if (gm.work > neededWork)
            GetComponent<MeshRenderer>().material = CantDo;
        else
            GetComponent<MeshRenderer>().material = Done;
    }

    private void OnMouseDown()
    {
        gm.SetField(this);
    }
}
