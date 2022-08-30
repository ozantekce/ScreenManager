using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PopUp : MonoBehaviour
{

    public bool Opened { get; protected set; }

    public abstract void Open();

    public abstract void Close();

}
