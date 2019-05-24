using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class TestUGUI : MonoBehaviour
{
    public Button button;
    public Texture2D texture2;
    public SpriteAtlas atlas;

    // Start is called before the first frame update
    void Start()
    {
        this.button.onClick.AddListener(() =>
        {
            Debug.Log("버튼 활성화");
            //var img = this.button.GetComponent<Image>();

            ////Rect rect = new Rect(0, 0, texture.width, texture.height);
            ////sprite.GetComponent<SpriteRenderer>().sprite = Sprite.Create(texture, rect, new Vector2(0.5f, 0.5f));

            //Rect rect = new Rect(0,0, texture2.width , texture2.height);
            //img.sprite = Sprite.Create(this.texture2, rect, new Vector3(0, 5f, 0.5f));

            this.atlas.GetSprite("btn_start_f");
        });    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
