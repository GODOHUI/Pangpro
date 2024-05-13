using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMain : MonoBehaviour
{

    // 이름입력해야한다
    // 버튼을 눌렀을때 네임UI로가야한다
    // Start is called before the first frame update

   public TMP_InputField InputField; //선언했고 유니티에서

   // string nameid;

    public void IDbtn()
    {
        GameManager.Instance.Username =InputField.text;             
        // Debug.Log(InputField.text);
       // nameid = InputField.text;
        SceneManager.LoadScene(1);
    }
    void Start()    
    {
        //InputField = GetComponent<TMP_InputField>();
       // InputField.text = "";   //공백으로 자리를 비어두겠다  


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(InputField.text);
        
    }
}
