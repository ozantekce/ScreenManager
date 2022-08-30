using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreen : Screen
{
    public override void Close()
    {
        Opened = false;
        gameObject.SetActive(false);
    }

    public override void Open()
    {
        Opened = true;
        gameObject.SetActive(true);
    }
}
