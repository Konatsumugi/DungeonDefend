using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Random = UnityEngine.Random;
public class GameManager : Singleton<GameManager>
{
    public UserData userData
    {
        get; private set;
    }
    protected override void Awake()
    {
        base.Awake();
        Game.Launch();
    }

    void Start()
    {
        userData = Game.Data.Load<UserData>();
        UILoading loading = GameUI.Instance.Get<UILoading>();
        loading.Load(null, (Action)(() =>
        {
            loading.Hide();
            GameUI.Instance.Get<UIHome>().Show();
        }));
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            GameUI.Instance.Get<UIWin>().Show();
        }
    }

}
