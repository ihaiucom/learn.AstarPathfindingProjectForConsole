using Model;
using System;
using System.Collections.Generic;
/** 
* ==============================================================================
*  @Author      	曾峰(zengfeng75@qq.com) 
*  @Web      		http://blog.ihaiu.com
*  @CreateTime      3/30/2018 9:58:29 AM
*  @Description:    
* ==============================================================================
*/
namespace UnityEngine
{
    public class SceneManager
    {
        public static bool dontAddGameObject { get; set; }
        public static void AddGameObject(GameObject go)
        {
            ActiveScene.AddGameObject(go);
        }

        public static Scene GetActiveScene()
        {
            return ActiveScene;
        }

        private static Scene _ActiveScene;
        private static Scene ActiveScene
        {
            get
            {
                if (_ActiveScene == null)
                    _ActiveScene = MainScene;
                return _ActiveScene;
            }

            set
            {
                _ActiveScene = value;
            }
       }

        private static Scene _MainScene;
        public static Scene MainScene
        {
            get
            {
                if (_MainScene == null)
                {
                    _MainScene = new Scene();
                    updates.Enqueue(_MainScene);
                }
                return _MainScene;
            }
        }

        public static void Unload(Scene scene)
        {
            scene.IsDisposed = true;

            if (_ActiveScene != null && _ActiveScene == scene)
            {
                _ActiveScene = MainScene;
            }
        }


        private static Queue<Scene> updates = new Queue<Scene>();
        private static Queue<Scene> updates2 = new Queue<Scene>();

        public static void Update()
        {
            while (updates.Count > 0)
            {
                Scene disposer = updates.Dequeue();
                if (disposer.IsDisposed)
                {
                    continue;
                }

                updates2.Enqueue(disposer);
                disposer.Update();
            }

            ObjectHelper.Swap(ref updates, ref updates2);
        }
    }
}
