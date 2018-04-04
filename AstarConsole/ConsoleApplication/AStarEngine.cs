using Pathfinding;
using Pathfinding.RVO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;

public class AStarEngine
{
    GameObjectManager behaviourManager = new GameObjectManager();

    public CustomTransform Bot1;

    public AStarEngine() 
    {
        //初始化
        CustomGameObject go = behaviourManager.Instantiate();
        AstarPath aStarPath = go.AddComponent<AstarPath>();
        AstarData data = new AstarData();
        data.cacheStartup = true;
        data.data_cachedStartup = ReadAllBytes("graph.bytes");
        aStarPath.data = data;

        CustomTransform target = new CustomTransform();
        target.position = new Vector3(25.28727f, 1.5f, -24.41525f);
        target.rotation = new Quaternion(0, 0, 0, 1);


        Bot1 = new CustomTransform();
        Bot1.position = new Vector3(-12.63644f, 0.1515305f, 0);
        Bot1.rotation = new Quaternion(0, 0, 0, 1);

        CustomGameObject rvoSimulator = behaviourManager.Instantiate();
        rvoSimulator.AddComponent<RVOSimulator>();

        Matrix4x4 m = Matrix4x4.identity;

        CustomGameObject agent1 = behaviourManager.Instantiate();
        agent1.AddComponent<Seeker>();
        AIPath ai1 = agent1.AddComponent<AIPath>();
        agent1.AddComponent<RVOController>();
        ai1.target = target;
        CustomTransform tr1 = agent1.GetComponent<CustomTransform>();
        tr1.position = Bot1.position;
        tr1.rotation = Bot1.rotation;
        tr1.PositionEvent += Tr1_PositionEvent;
        tr1.QuaternionEvent += Tr1_QuaternionEvent;




        behaviourManager.Awake();

        behaviourManager.Start();

        behaviourManager.OnEnable();

        //behaviourManager.OnDisable();

        // behaviourManager.OnDestroy();

        System.Timers.Timer t = new System.Timers.Timer(20);//实例化Timer类，设置间隔时间为10000毫秒；
        t.Elapsed += new System.Timers.ElapsedEventHandler(Update);//到达时间的时候执行事件；
        t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
        t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
    }

    public void Update(object source, System.Timers.ElapsedEventArgs e)
    {
        behaviourManager.Update();
        behaviourManager.FixedUpdate();
        CustomHelp.CoroutineTick();
    }

    private void Tr1_QuaternionEvent(Quaternion q)
    {
        Bot1.rotation = q;
    }

    private void Tr1_PositionEvent(Vector3 p)
    {
        Bot1.position = p;
    }



    public static byte[] ReadAllBytes(string path)
    {
        byte[] content = null;

        FileStream stream = File.OpenRead(path);
        content = new byte[stream.Length];
        stream.Read(content, 0, content.Length);
        stream.Close();
        return content;
    }


}
