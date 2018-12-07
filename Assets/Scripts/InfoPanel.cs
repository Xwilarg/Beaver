using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
    [SerializeField]
    private Text nameText, descriptionText;
    [SerializeField]
    private Image image;
    [SerializeField]
    private GameObject panelGo;

    public void SetContent(Field f, FieldManager.RoomInfo infos)
    {
        if (f == null)
            panelGo.SetActive(false);
        else
        {
            panelGo.SetActive(true);
            nameText.text = f.name;
            descriptionText.text = "Room size: " + infos.Size + " m²";
            image.sprite = infos.Image;
        }
    }
}
