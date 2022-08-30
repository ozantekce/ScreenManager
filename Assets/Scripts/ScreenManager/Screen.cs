using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Screen : MonoBehaviour
{

    public bool Opened { get; protected set; }

    public abstract void Open();

    public abstract void Close();



}
