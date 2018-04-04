using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class GameObjectManager
{
    public List<CustomGameObject> list = new List<CustomGameObject>();
    public void Awake()
    {
#if !UNITY
        Time.Init();
#endif
        for (int i = 0; i < list.Count; i++)
        {
            list[i].Awake();
        }
    }

    public void Start()
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i].Start();
        }
    }

    public void Update()
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i].Update();
        }
    }

    public void FixedUpdate()
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i].FixedUpdate();
        }
    }

    public void OnEnable()
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i].OnEnable();
        }
    }

    public void OnDisable()
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i].OnDisable();
        }
    }

    public void OnDestroy()
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i].OnDestroy();
        }
    }

    public CustomGameObject Instantiate( )
    {
        CustomGameObject o = new CustomGameObject();
        list.Add(o);
        return o;
    }

    public void Destroy(CustomGameObject b)
    {
        list.Remove(b);
        b = null;
    }


}
