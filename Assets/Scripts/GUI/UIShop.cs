using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class UIShop : UIElement
{
    public override bool ManualHide => true;
    public override bool DestroyOnHide => false;
    public override bool UseBehindPanel => true;

    [SerializeField] private Button btn_close;

    private void Start()
    {
        btn_close.onClick.AddListener(ClosePopUp);

    }

    private void ClosePopUp()
    {
        GameUI.Instance.Get<UIShop>().Hide();
    }

}
