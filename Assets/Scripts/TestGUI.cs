using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour
{
    public UIButton btn;
    


    // Start is called before the first frame update
    void Start()
    {
        this.btn.onClick.Add(new EventDelegate(() =>
        {
            Debug.Log("버튼 클릭");
            this.btn.GetComponent<UISprite>().spriteName = "btn_start_f";
            this.btn.normalSprite = "btn_start_f";
        }));    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
