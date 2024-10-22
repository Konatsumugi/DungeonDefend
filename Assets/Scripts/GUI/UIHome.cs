using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UIHome : UIElement
{
    public override bool ManualHide => true;
    public override bool DestroyOnHide => false;
    public override bool UseBehindPanel => false;

    [SerializeField] private Button btn_play;
    [SerializeField] private Button btn_setting;
    [SerializeField] private Button btn_level;

    public void UIInGame()
    {
        Hide();
        GameUI.Instance.Get<UIInGame>().Show();
    }

    public void UISetting()
    {
        Hide();
        GameUI.Instance.Get<UISetting>().Show();
    }

    public void UILevel()
    {
        Hide();
        GameUI.Instance.Get<UILevel>().Show();
    }
    private void Start()
    {
        btn_play.onClick.AddListener(UIInGame);
        btn_setting.onClick.AddListener(UISetting);
        btn_level.onClick.AddListener(UILevel);
    }
}
