using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour
{
    [SerializeField]
    private Field kitchen, livingRoom, hall, office, bedroom1, dressing, wc, corridor, stair, bathroom;
    [SerializeField]
    private Sprite kitchenImg, livingRoomImg, hallImg, officeImg, bedroom1Img, dressingImg, wcImg, corridorImg, stairImg, bathroomImg;

    public struct RoomInfo
    {
        public float Size;
        public Sprite Image;
    }

    private GameManager gm;

    public void IncreaseWork()
    {
        gm.CurrentField.IncreaseWork();
    }

    public Dictionary<Field, RoomInfo> allRooms;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        allRooms = new Dictionary<Field, RoomInfo>();
        allRooms.Add(kitchen, new RoomInfo() {
            Size = 12.67f,
            Image = kitchenImg
        });
        allRooms.Add(livingRoom, new RoomInfo() {
            Size = 42f,
            Image = livingRoomImg
        });
        allRooms.Add(hall, new RoomInfo() {
            Size = 3.09f,
            Image = hallImg
        });
        allRooms.Add(office, new RoomInfo() {
            Size = 10.68f,
            Image = officeImg
        });
        allRooms.Add(bedroom1, new RoomInfo() {
            Size = 15.56f,
            Image = bedroom1Img
        });
        allRooms.Add(dressing, new RoomInfo() {
            Size = 6.80f,
            Image = dressingImg
        });
        allRooms.Add(wc, new RoomInfo() {
            Size = 1.99f,
            Image = wcImg
        });
        allRooms.Add(corridor, new RoomInfo() {
            Size = 3.58f,
            Image = corridorImg
        });
        allRooms.Add(stair, new RoomInfo() {
            Size = 0.81f,
            Image = stairImg
        });
        allRooms.Add(bathroom, new RoomInfo() {
            Size = 9.41f,
            Image = bathroomImg
        });
    }
}
