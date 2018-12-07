using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour
{
    [SerializeField]
    private Field kitchen, livingRoom, hall, office, bedroom1, dressing, wc, corridor, stair, bathroom;

    private struct RoomInfo
    {
        public float Size;
    }

    private Dictionary<Field, RoomInfo> allRooms;

    private void Start()
    {
        allRooms = new Dictionary<Field, RoomInfo>();
        allRooms.Add(kitchen, new RoomInfo() {
            Size = 12.67f
        });
        allRooms.Add(livingRoom, new RoomInfo() {
            Size = 42f
        });
        allRooms.Add(hall, new RoomInfo() {
            Size = 3.09f
        });
        allRooms.Add(office, new RoomInfo() {
            Size = 10.68f
        });
        allRooms.Add(bedroom1, new RoomInfo() {
            Size = 15.56f
        });
        allRooms.Add(dressing, new RoomInfo() {
            Size = 6.80f
        });
        allRooms.Add(wc, new RoomInfo() {
            Size = 1.99f
        });
        allRooms.Add(corridor, new RoomInfo() {
            Size = 3.58f
        });
        allRooms.Add(stair, new RoomInfo() {
            Size = 0.81f
        });
        allRooms.Add(bathroom, new RoomInfo() {
            Size = 9.41f
        });
    }
}
