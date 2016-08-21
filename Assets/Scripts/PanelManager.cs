using UnityEngine;
using UnityEngine.EventSystems;

public class PanelManager : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    
    ControllerFader con;

    void Start()
    {
        con = gameObject.GetComponent<ControllerFader>();
    }

    public void OnPointerUp(PointerEventData data)
    {
        con.destroyIcon();
    }


    public void OnPointerDown(PointerEventData data)
    {
        Vector2 pos = new Vector2(data.position.x, data.position.y);
        con.createIcon(pos);
    }
}
    
