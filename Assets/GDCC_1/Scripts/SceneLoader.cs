using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prowl.Runtime;
using Prowl.Runtime.Resources;
using Prowl.Vector;

namespace MegaProwl;

public class SceneLoader : MonoBehaviour
{
    public GameObject[] dontDestroy;
    public AssetRef<Scene> gameScene;

    public void LoadGame()
    {
        foreach (var bla in dontDestroy)
        {
            Scene.DontDestroyOnLoad(bla);
        }
        Scene.DontDestroyOnLoad(gameScene.Res.RootObjects.Single());
        Scene.Load(gameScene.Res);
    }
}
