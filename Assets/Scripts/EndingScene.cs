using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Manager.Sound;

public class EndingScene : MonoBehaviour
{
    public GameObject _credit;

    bool _isMove = false;

    float _Speed = 5f;

    void Start()
    {
        SoundPlayer.instance.PlayBGM("Bg_1");
        Invoke("Wait", 3f);
    }

    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Space))
            Application.Quit(0);

        if (Input.GetKey(KeyCode.Q))
            _Speed = 20f;
        if (Input.GetKeyUp(KeyCode.Q))
            _Speed = 5f;
    }

    void Move()
    {
        if (!_isMove)
            return;

        _credit.transform.position += Vector3.up * _Speed * Time.deltaTime;
    }

    void Wait()
    {
        _isMove = true;
    }
}
