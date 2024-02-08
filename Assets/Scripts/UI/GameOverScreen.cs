using UnityEngine;
using UnityEngine.Events;

public class GameOverScreen : Screen
{
    public event UnityAction RestartButtonClick;
    
    protected override void OnButtonClick()
    {
        Debug.Log("перезагрузка");
        RestartButtonClick?.Invoke();
    }

    public override void Open()
    {
        Debug.Log("геймовер скрин открылся");
        CanvasGroup.alpha = 1;
        Button.interactable = true;
    }

    public override void Close()
    {
        Debug.Log("геймовер скрин закрылся");
        //gameObject.SetActive(false);
        CanvasGroup.alpha = 0;
        Button.interactable = false;
    }
}
