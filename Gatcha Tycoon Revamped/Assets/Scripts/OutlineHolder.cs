using UnityEngine;

public class OutlineHolder : MonoBehaviour
{
    [SerializeField] Outline[] outlines;

    public void Activate()
    {
        foreach (Outline outline in outlines)
        {
            outline.enabled = true;
            //outline.OutlineWidth = 4;
        }
    }
    public void Deactivate()
    {
        foreach (Outline outline in outlines)
        {
            outline.enabled = false;
            //outline.OutlineWidth = 0;
        }
    }
}
