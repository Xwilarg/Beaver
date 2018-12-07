using System.Collections.Generic;
using UnityEngine;

public class Db : MonoBehaviour
{
    public struct Worker
    {
        public bool IsManager;
        public string Password;
    }

    public enum Work
    {
        painter,
        plumber,
        electrician,
        bricklayer,
        tiler,
        capenter,
        heatingEngineer,
        roofer,
        platter,
        licksmith,
        stoneCarver
    }

    [SerializeField]
    private Sprite painterImg, plumberImg, electricianImg, bricklayerImg, tilerImg, capenterImg, heatingEngineerImg, rooferImg, platterImg, licksmithImg, stoneCarverImg;

    private Dictionary<Work, Sprite> allWorks;

    private void Start()
    {
        allWorks = new Dictionary<Work, Sprite>()
        {
        };
    }

    private readonly Dictionary<string, Worker> users = new Dictionary<string, Worker>() // Sample Db, need to be refactor using a real one
    {
        { "Renia", new Worker() {
            IsManager = true,
            Password = "awak_"
        } },
        { "Jenk",  new Worker() {
            IsManager = true,
            Password = "kiRR@"
        } },
        { "Era",  new Worker() {
            IsManager = false,
            Password = "rekk"
        }  },
        { "Kinoi",  new Worker() {
            IsManager = false,
            Password = "_Ino"
        } },
        { "Denko",  new Worker() {
            IsManager = false,
            Password = "parr"
        }  },
        { "Mino",  new Worker() {
            IsManager = false,
            Password = "@w@"
        } },
        { "Wan",  new Worker() {
            IsManager = false,
            Password = "dennn"
        }  }
    };

    public bool? IsMaster(string user, string password)
    {
        if (!users.ContainsKey(user))
            return (null);
        var me = users[user];
        if (me.Password == password)
            return (me.IsManager);
        return (null);
    }
}
