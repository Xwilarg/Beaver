using UnityEngine;
using UnityEngine.UI;

public class DebugPannel : MonoBehaviour
{
    private bool isEnabled;
    [SerializeField]
    private Text description;

    public void SetText(string content)
    {
        description.text = content;
    }
}
