using System;
using UnityEngine;
using UnityEngine.EventSystems;

public static class UIApp{

    public static void PN_Login_Open(UICtx uictx,Action OnStartClickHandle){
        PN_Login panel = uictx.pn_login ;
        if(panel == null){
            uictx.assetsCtx.Panel_TryGetPrefab("panel_Login",out GameObject prefab);
            panel = GameObject.Instantiate(prefab,uictx.canvas.transform).GetComponent<PN_Login>();
            uictx.pn_login =panel;

            panel .OnStartClickHandle =OnStartClickHandle;
        }
        panel.Show();
        EventSystem.current.SetSelectedGameObject(panel.startBtn.gameObject);
    }
    public static void PN_Login_Close(UICtx uictx){
        PN_Login panel = uictx.pn_login ;

    }
}