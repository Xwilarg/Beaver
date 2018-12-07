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
            { Work.STONECARVER, managerImg },
            { Work.PLUMBER, painterImg },
            { Work.ELECTRICIAN, plumberImg },
            { Work.CARPENTER, electricianImg },
            { Work.WOODWORKER, bricklayerImg },
            { Work.PLASTERER, tilerImg },
            { Work.FLOORSETTER, carpenterImg },
            { Work.PAINTER, heatingEngineerImg },
            { Work.LOCKSMITH, rooferImg },
            { Work.MANAGER, platterImg },
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
            Job = Work.MANAGER
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
