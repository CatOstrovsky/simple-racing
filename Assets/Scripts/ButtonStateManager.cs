using UnityEngine.EventSystems;

public class ButtonStateManager : EventTrigger
{
    public bool downed = false;


    public override void OnPointerDown(PointerEventData data)
    {
        downed = true;
    }

    public override void OnPointerUp(PointerEventData data)
    {
        downed = false;
    }

}
