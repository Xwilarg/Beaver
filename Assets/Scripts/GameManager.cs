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

    public Field CurrentField { private set; get; }

    public void SetField(Field f)
    {
        if (CurrentField != null)
            CurrentField.GetComponent<MeshRenderer>().material = baseMat;
        CurrentField = f;
        if (CurrentField != null)
            CurrentField.GetComponent<MeshRenderer>().material = selectedMat;
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
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
