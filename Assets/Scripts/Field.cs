using UnityEngine;

public class Field : MonoBehaviour
{
    private GameManager gm;

    [SerializeField]
    private Material CantDo, CanDo, Done, Doing;

    private enum Status
    {
        CantDo,
        CanDo,
        Done
    }

    [SerializeField]
    private Db.Work neededWork;

    public Db.Work GetWork()
    {
        return (neededWork);
    }

    public void IncreaseWork()
    {
        if (gm.work == neededWork)
        {
            neededWork++;
            UpdateMats();
        }
    }

    public void DoingWork()
    {
        if (gm.work == neededWork)
            GetComponent<MeshRenderer>().material = Doing;
    }

    private void UpdateMats()
    {
        if (gm.work == neededWork)
            GetComponent<MeshRenderer>().material = CanDo;
        else if (gm.work > neededWork)
            GetComponent<MeshRenderer>().material = CantDo;
        else
            GetComponent<MeshRenderer>().material = Done;
    }

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        UpdateMats();
    }

    private void OnMouseDown()
    {
        gm.SetField(this);
    }
}
