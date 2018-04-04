using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class CustomHelp
{
    static LinkedList<IEnumerator> CoroutineList = new LinkedList<IEnumerator>();
    public static void StartCoroutine(IEnumerator enumerator)
    {
        CoroutineList.AddLast(enumerator);
    }
    public static void CoroutineTick()
    {
        var node = CoroutineList.First;
        while (node != null)
        {
            IEnumerator cur_etor = node.Value;
            bool ret = true;
            if (cur_etor.Current is WaitFream)
            {
                WaitFream wf = (WaitFream)cur_etor.Current;
                if (!wf.Tick())
                {
                    ret = cur_etor.MoveNext();
                }
            }
            else
            {
                ret = cur_etor.MoveNext();
            }
            //删除节点
            if (ret == false)
            {
                CoroutineList.Remove(node);
            }
            node = node.Next;
        }
    }

    class WaitFream
    {
        int wait_count = 0;
        public WaitFream(int count)
        {
            wait_count = count;
        }
        public bool Tick()
        {
            return --wait_count > 0;
        }
    }

#if UNITY
     public static UnityEngine.Quaternion CustomQuaternionToToUnity3D(UnityEngine.Quaternion uq)
    {
       return uq;
    }
#else
    public static Quaternion CustomQuaternionToToUnity3D(UnityEngine.Quaternion uq)
    {
        Quaternion q = new Quaternion();
        q.w = uq.w;
        q.x = uq.x;
        q.y = uq.y;
        q.z = uq.z;
        return q;
    }

    public static UnityEngine.Quaternion CustomQuaternionToToUnity3D(Quaternion q)
    {
        UnityEngine.Quaternion uq = new UnityEngine.Quaternion();
        uq.w = q.w;
        uq.x = q.x;
        uq.y = q.y;
        uq.z = q.z;
        return uq;
    }

#endif


}

