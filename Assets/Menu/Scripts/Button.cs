using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject button_back;
    public GameObject button_text;
    public Text click;
    private SpriteRenderer rend_back;
    private SpriteRenderer rend_text;

    void Start()
    {
        rend_back = button_back.GetComponent<SpriteRenderer>();
        rend_text = button_text.GetComponent<SpriteRenderer>();
    }
    
    void OnMouseDown()
    {
        if (button_text.tag == "NEWGAME")
            Application.LoadLevel("Game");
        else if (button_text.tag == "QUITGAME")
            Application.Quit();
        else
            click.text = "click:" + button_text.tag;
    }

    void OnMouseEnter()
    {
        rend_back.color = Color.black;
        rend_text.color = Color.black;
    }

    void OnMouseOver()
    {
        rend_back.color = Color.black;
        rend_text.color = Color.black;
    }

    void OnMouseExit()
    {
        rend_back.color = Color.white;
        rend_text.color = Color.white;
    }
}
