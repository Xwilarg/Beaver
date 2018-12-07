using System.Collections.Generic;
using UnityEngine;

public class Db : MonoBehaviour
{
    public struct Worker
    {
        public bool IsManager;
        public string Password;
        public Work Job;
    }

    public enum Work
    {
        STONECARVER,
        PLUMBER,
        ELECTRICIAN,
        CARPENTER,
        WOODWORKER,
        PLASTERER,
        FLOORSETTER,
        PAINTER,
        LOCKSMITH,
        MANAGER
    }

    [SerializeField]
    private Sprite managerImg, painterImg, plumberImg, electricianImg, bricklayerImg, tilerImg, carpenterImg, heatingEngineerImg, rooferImg, platterImg, locksmithImg, stoneCarverImg;

    public Dictionary<Work, Sprite> allWorks;

    private void Start()
    {
        allWorks = new Dictionary<Work, Sprite>()
        {
            { Work.STONECARVER, stoneCarverImg },
            { Work.PLUMBER, plumberImg },
            { Work.ELECTRICIAN, electricianImg },
            { Work.CARPENTER, carpenterImg },
            { Work.WOODWORKER, platterImg },
            { Work.PLASTERER, platterImg },
            { Work.FLOORSETTER, tilerImg },
            { Work.PAINTER, painterImg },
            { Work.LOCKSMITH, locksmithImg },
            { Work.MANAGER, managerImg },
        };
    }

    private readonly Dictionary<string, Worker> users = new Dictionary<string, Worker>() // Sample Db, need to be refactor using a real one
    {
        { "Renia", new Worker() {
            IsManager = true,
            Password = "awak_",
            Job = Work.MANAGER
        } },
        { "Jenk",  new Worker() {
            IsManager = true,
            Password = "kiRR@",
            Job = Work.LOCKSMITH
        } },
        { "Era",  new Worker() {
            IsManager = false,
            Password = "rekk",
            Job = Work.ELECTRICIAN
        }  },
        { "Kinoi",  new Worker() {
            IsManager = false,
            Password = "_Ino",
            Job = Work.FLOORSETTER
        } },
        { "Wan",  new Worker() {
            IsManager = false,
            Password = "dennn",
            Job = Work.WOODWORKER
        }  }
    };

    public Worker? IsMaster(string user, string password)
    {
        if (!users.ContainsKey(user))
            return (null);
        var me = users[user];
        if (me.Password == password)
            return (me);
        return (null);
    }
}
