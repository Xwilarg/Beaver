using UnityEngine;
using UnityEngine.UI;

public class DebugPannel : MonoBehaviour
{
    private bool isEnabled;
    [SerializeField]
    private GameObject debugPannel;
    [SerializeField]
    private Text description;

    public void SetText(string content)
    {
        description.text = content;
    }

    private void Start()
    {
        isEnabled = Application.isEditor;
        if (isEnabled)
            debugPannel.SetActive(true);
    }
}
