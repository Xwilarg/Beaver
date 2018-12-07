using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool isMaster;

    [Header("UI")]
    [SerializeField]
    private Db db;
    [SerializeField]
    private InputField userField;
    [SerializeField]
    private InputField passwordField;
    [SerializeField]
    private Text errorText;
    [Header("Materials")]
    [SerializeField]
    private Material baseMat;
    [SerializeField]
    private Material selectedMat;

    private InfoPanel infoPanel;
    private FieldManager fm;

    public Field CurrentField { private set; get; }

    public void SetField(Field f)
    {
        if (CurrentField != null)
            CurrentField.GetComponent<MeshRenderer>().material = baseMat;
        CurrentField = f;
        if (CurrentField != null)
            CurrentField.GetComponent<MeshRenderer>().material = selectedMat;
        if (infoPanel == null)
        {
            infoPanel = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<InfoPanel>();
            fm = GameObject.FindGameObjectWithTag("FieldManager").GetComponent<FieldManager>();
        }
        if (f != null)
            infoPanel.SetContent(f, fm.allRooms[f]);
        else
            infoPanel.SetContent(null, new FieldManager.RoomInfo());
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        infoPanel = null;
    }

    public void Launch()
    {
        bool? res = db.IsMaster(userField.text, passwordField.text);
        if (res == null)
            errorText.text = "This user does not exist.";
        else
        {
            isMaster = res.Value;
            SceneManager.LoadScene("main");
        }
    }
}
