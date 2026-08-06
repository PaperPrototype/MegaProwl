using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prowl.Runtime;
using Prowl.Runtime.Resources;
using Prowl.Vector;

namespace MegaProwl;

public class SceneLoader : MonoBehaviour
{
    public AssetRef<Scene> gameScene;

    public void LoadGame()
    {
        Scene.DontDestroyOnLoad(this.GameObject);
        Scene.Load(gameScene.Res);
    }
}
