using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CustomGameObject
{
    public List<BehaviourBase> list = new List<BehaviourBase>();

    public CustomTransform transform;
    public void Awake()
    {
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
            list[i].enabled = true;
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

    public CustomGameObject()
    {
        this.transform =AddComponent<CustomTransform>();
    }

    public T AddComponent<T>() where T : BehaviourBase
    {
        T t = System.Activator.CreateInstance<T>();
        list.Add(t);
        t.transform = this.transform;
        t.gameObject = this;
        return t;
    }

    public T GetComponent<T>() where T : BehaviourBase
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] is T)
            {
                return list[i] as T;
            }
        }
        return null;
    }

    public void RemoveComponent<T>() where T : BehaviourBase
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] is T)
            {
                list.Remove(list[i]);
            }
        }
    }
}
