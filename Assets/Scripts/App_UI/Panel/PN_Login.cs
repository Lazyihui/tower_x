using System;
using UnityEngine;
using UnityEngine.UI;

public class PN_Login : MonoBehaviour{
    [SerializeField] public Button startBtn;

    public Action OnStartClickHandle;

    public void Ctor(){
        startBtn.onClick.AddListener(()=>{
            OnStartClickHandle.Invoke();
        });
    }

    public void Show(){
        gameObject.SetActive(true);
    }

    public void Close(){
        gameObject.SetActive(false);
    }

    void OnStartClick(){
        Debug.Log("hhhh");
    }
}
