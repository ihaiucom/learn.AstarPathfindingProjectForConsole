using System;
using System.Collections.Generic;
using System.Threading;
/** 
* ==============================================================================
*  @Author      	曾峰(zengfeng75@qq.com) 
*  @Web      		http://blog.ihaiu.com
*  @CreateTime      3/30/2018 3:47:56 PM
*  @Description:    
* ==============================================================================
*/

public class MainThreadRunner
{
    public static OneThreadSynchronizationContext content { get; private set; }
    public static void Install()
    {
        content = new OneThreadSynchronizationContext();
    }

    public static void Update()
    {
        content.Update();
    }

    public static void Post(SendOrPostCallback callback, object state)
    {
        content.Post(callback, state);
    }

    public static void Run(Action callback)
    {
        content.Run(callback);
    }


}