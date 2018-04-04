using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Internal;

public class CustomTransform : BehaviourBase
{

    public delegate void PositionDelegate(Vector3 p);
    public event PositionDelegate PositionEvent;

    public delegate void QuaternionDelegate(Quaternion q);
    public event QuaternionDelegate QuaternionEvent;

    public override void Awake()
    {
        base.Awake();
    }

    private Quaternion _rotation;

    public Quaternion rotation
    {
        get
        {
            return _rotation;
        }

        set
        {
            if (QuaternionEvent != null)
                QuaternionEvent(value);
            _rotation = value;
        }
    }

    private Vector3 _position;
    public Vector3 position
    {
        get
        {
            return _position;
        }

        set
        {
            if (PositionEvent != null)
                PositionEvent(value);
            _position = value;
        }
    }

    public Vector3 up
    {
        get
        {
            return (Vector3)(this.rotation * Vector3.up);
        }
        set
        {
            this.rotation = Quaternion.FromToRotation(Vector3.up, value);
        }
    }

    public Vector3 forward
    {
        get
        {
            return (Vector3)(this.rotation * Vector3.forward);
        }
        set
        {
            this.rotation = Quaternion.LookRotation(value);
        }
    }




}

