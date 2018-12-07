using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isMaster;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void LaunchWorker()
    {
        isMaster = false;
        SceneManager.LoadScene("main");
    }

    public void LaunchMaster()
    {
        isMaster = true;
        SceneManager.LoadScene("main");
    }
}
