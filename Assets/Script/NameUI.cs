using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameUI : MonoBehaviour
{
    //textMeshPro �� ���� �̸��� �ٲ� ���� �ٲ�����Ѵ�
    //textMeshPro �� �����;��Ѵ�

    //playername�� �����Ѵ�

    // �Է¹����� ���⼭ ǥ�����ش�
    public TextMeshProUGUI playername;

    
    public void PlayerName()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        playername.text = GameManager.Instance.Username;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
