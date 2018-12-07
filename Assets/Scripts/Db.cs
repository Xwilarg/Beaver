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
        manager,
        painter,
        plumber,
        electrician,
        bricklayer,
        tiler,
        carpenter,
        heatingEngineer,
        roofer,
        platter,
        locksmith,
        stoneCarver
    }

    [SerializeField]
    private Sprite managerImg, painterImg, plumberImg, electricianImg, bricklayerImg, tilerImg, carpenterImg, heatingEngineerImg, rooferImg, platterImg, locksmithImg, stoneCarverImg;

    public Dictionary<Work, Sprite> allWorks;

    private void Start()
    {
        allWorks = new Dictionary<Work, Sprite>()
        {
            { Work.manager, managerImg },
            { Work.painter, painterImg },
            { Work.plumber, plumberImg },
            { Work.electrician, electricianImg },
            { Work.bricklayer, bricklayerImg },
            { Work.tiler, tilerImg },
            { Work.carpenter, carpenterImg },
            { Work.heatingEngineer, heatingEngineerImg },
            { Work.roofer, rooferImg },
            { Work.platter, platterImg },
            { Work.locksmith, locksmithImg },
            { Work.stoneCarver, stoneCarverImg }
        };
    }

    private readonly Dictionary<string, Worker> users = new Dictionary<string, Worker>() // Sample Db, need to be refactor using a real one
    {
        { "Renia", new Worker() {
            IsManager = true,
            Password = "awak_",
            Job = Work.manager
        } },
        { "Jenk",  new Worker() {
            IsManager = true,
            Password = "kiRR@",
            Job = Work.manager
        } },
        { "Era",  new Worker() {
            IsManager = false,
            Password = "rekk",
            Job = Work.heatingEngineer
        }  },
        { "Kinoi",  new Worker() {
            IsManager = false,
            Password = "_Ino",
            Job = Work.carpenter
        } },
        { "Denko",  new Worker() {
            IsManager = false,
            Password = "parr",
            Job = Work.locksmith
        }  },
        { "Mino",  new Worker() {
            IsManager = false,
            Password = "@w@",
            Job = Work.stoneCarver
        } },
        { "Wan",  new Worker() {
            IsManager = false,
            Password = "dennn",
            Job = Work.bricklayer
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
