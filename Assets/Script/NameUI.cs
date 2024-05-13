using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameUI : MonoBehaviour
{
    //textMeshPro 가 유저 이름이 바뀔때 마다 바꿔줘야한다
    //textMeshPro 를 가져와야한다

    //playername에 들어가야한다

    // 입력받은걸 여기서 표현해준다
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
