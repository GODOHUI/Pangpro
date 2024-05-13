using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;
    public string Username;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
