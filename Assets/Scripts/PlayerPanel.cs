using UnityEngine;
using UnityEngine.UI;

public class PlayerPanel : MonoBehaviour
{
    [SerializeField]
    private Text nameText;
    [SerializeField]
    private Image image;

    private void Start()
    {
        GameManager gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        image.sprite = gm.workSprite;
        nameText.text = gm.Username;
    }
}
