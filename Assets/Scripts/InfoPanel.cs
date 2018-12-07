using System;
using System.Linq;
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
            string jobName = f.GetWork().ToString();
            descriptionText.text = "Room size:\n" + infos.Size + " m²" + Environment.NewLine + Environment.NewLine + "Waiting for " + jobName[0] + new string(jobName.Skip(1).ToArray()).ToLower();
            image.sprite = infos.Image;
        }
    }
}
