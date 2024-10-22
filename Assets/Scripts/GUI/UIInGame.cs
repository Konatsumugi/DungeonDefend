using UnityEngine;
using UnityEngine.UI;


public class UIInGame : UIElement
{
    public override bool ManualHide => true;
    public override bool DestroyOnHide => false;
    public override bool UseBehindPanel => false;


    [SerializeField] private Button btn_pause;

    private void Start()
    {
        btn_pause.onClick.AddListener(UIPause);
    }

    private void UIPause()
    {
        GameUI.Instance.Get<UIPause>().Show();
    }

}