using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMain : MonoBehaviour
{

    // �̸��Է��ؾ��Ѵ�
    // ��ư�� �������� ����UI�ΰ����Ѵ�
    // Start is called before the first frame update

   public TMP_InputField InputField; //�����߰� ����Ƽ����

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
       // InputField.text = "";   //�������� �ڸ��� ���ΰڴ�  


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(InputField.text);
        
    }
}
