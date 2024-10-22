using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UISetting : UIElement
{
    public override bool ManualHide => true;
    public override bool DestroyOnHide => false;
    public override bool UseBehindPanel => false;

    [SerializeField] private Button btn_close;

    private void Start()
    {
        btn_close.onClick.AddListener(CloseSetting);
    }

    private void CloseSetting()
    {
        GameUI.Instance.Get<UIHome>().Show();
        Hide();
    }

}
