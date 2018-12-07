using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool isMaster;

    [SerializeField]
    private Db db;
    [SerializeField]
    private InputField userField;
    [SerializeField]
    private InputField passwordField;
    [SerializeField]
    private Text errorText;

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
