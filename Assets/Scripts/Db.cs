using System.Collections.Generic;
using UnityEngine;

public class Db : MonoBehaviour
{
    public class Tuple<T, N>
    {
        public Tuple(T item1, N item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public T Item1 { private set; get; }
        public N Item2 { private set; get; }
    }

    private readonly Dictionary<string, Tuple<string, bool>> users = new Dictionary<string, Tuple<string, bool>>() // Sample Db, need to be refactor using a real one
    {
        { "Renia", new Tuple<string, bool>("awak_", true) },
        { "Jenk", new Tuple<string, bool>("kiRR@", true) },
        { "Era", new Tuple<string, bool>("rekk", false) },
        { "Kinoi", new Tuple<string, bool>("_Ino", false) },
        { "Denko", new Tuple<string, bool>("parr", false) },
        { "Mino", new Tuple<string, bool>("@w@", false) },
        { "Wan", new Tuple<string, bool>("dennn", false) }
    };

    public bool? IsMaster(string user, string password)
    {
        if (!users.ContainsKey(user))
            return (null);
        var me = users[user];
        if (me.Item1 == password)
            return (me.Item2);
        return (null);
    }
}
