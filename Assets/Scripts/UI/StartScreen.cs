using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.Events;

public class StartScreen : Screen
{
    public event UnityAction PlayButtonClick;

    public override void Open()
    {
        Debug.Log("Старт скрин открылся");
        CanvasGroup.alpha = 1;
        Button.interactable = true;
    }

    public override void Close()
    {
        Debug.Log("Старт скрин закрылся");
        gameObject.SetActive(false);
        CanvasGroup.alpha = 0;
        Button.interactable = false;
    }

    protected override void OnButtonClick()
    {
        Debug.Log("НАЖАТ СТАРТ");
        PlayButtonClick?.Invoke();
    }
}
