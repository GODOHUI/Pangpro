using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class Selectchar : MonoBehaviour
{
    public Character character;
    public Animator animator;
    public SpriteRenderer sr;

    private void OnMouseUpAsButton()
    {
        GameManager.Instance.currentcharacter = character;
        OnSelect();

    }
    void Start()
    {
     //   animator = GetComponent<Animator>();
       // sr = GetComponent<SpriteRenderer>();    
    }
    public void Btnchar()
    {
        GameManager.Instance.currentcharacter = character;
        SceneManager.LoadScene(0);
       // OnSelect();
    }
    
   void OnSelect()
    {

       animator.SetBool("IsWalk",true);
       // sr.color = new Color(1f,1f,1f);
        Debug.Log("´­·¶À½");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
