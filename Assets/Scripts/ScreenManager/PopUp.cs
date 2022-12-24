using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PopUp : MonoBehaviour,IScreenElement, IPointerDownHandler
{

    public bool Opened { get; protected set; }

    public virtual void Open()
    {

        Opened = true;
        gameObject.SetActive(true);
    }

    public virtual void Close()
    {

        Opened=false;
        gameObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.SetAsLastSibling();
    }



}
