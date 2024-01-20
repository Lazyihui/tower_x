using System.Collections.Generic;
using UnityEngine;


public class AssetsCtx {

    public Dictionary<string,GameObject> panels;

    public AssetsCtx(){
        panels = new Dictionary<string, GameObject> ();

    }

    public bool Panel_TryGetPrefab(string name, out GameObject prefab){
        return panels.TryGetValue(name,out prefab);
    }
}