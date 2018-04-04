using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class BehaviourBase
{
    public  CustomGameObject gameObject = null;

    public CustomTransform transform;

    public bool enabled;

    public virtual void Awake() { }

    public virtual void Start() { }

    public virtual void Update() { }

    public virtual void FixedUpdate() { }

    public virtual void OnEnable() { }

    public virtual void OnDisable() { }

    public virtual void OnDestroy() { }

    public virtual void OnApplicationQuit() { }

    public T GetComponent<T>() where T : BehaviourBase
    {
        if (this.gameObject != null)
            return gameObject.GetComponent<T>() as T;
        else
            return null;
    }
}

