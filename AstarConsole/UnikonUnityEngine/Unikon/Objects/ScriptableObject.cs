using System;
using System.Collections.Generic;
/** 
* ==============================================================================
*  @Author      	曾峰(zengfeng75@qq.com) 
*  @Web      		http://blog.ihaiu.com
*  @CreateTime      3/30/2018 5:24:07 PM
*  @Description:    
* ==============================================================================
*/
namespace UnityEngine
{
    public class ScriptableObject : Object
    {

        public static T CreateInstance<T>() where T : ScriptableObject
        {
            return (T)((object)ScriptableObject.CreateInstance(typeof(T)));
        }


        public static ScriptableObject CreateInstance(Type type)
        {
            return (ScriptableObject)Activator.CreateInstance(type);
        }
    }
}
