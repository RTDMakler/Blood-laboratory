using UnityEngine;

public class Outliner : MonoBehaviour
{
    Outline outline;
    Outline[] partsOfMicroscopeOutline = new Outline [29];
    void Start()
    {
        outline = gameObject.GetComponent<Outline>();
        outline.enabled = false;
        GetMicroscopeOutline();
    }
    
    void OnMouseEnter()
    {
        if (outline.gameObject.name == "partOfMicroscope")
        {
            OutlineOnMicroscope();
        }
        else
        {
            outline.enabled = true;
        }
    }
    private void OnMouseExit()
    {
        if (outline.gameObject.name == "partOfMicroscope")
        {
            OutlineOffMicroscope();
        }
        else
        {
            outline.enabled = false;
        }
    }
    void OutlineOnMicroscope()
    {
        foreach(var partMicroscope in partsOfMicroscopeOutline)
        {
            partMicroscope.enabled = true;
        }
        
    }
    void OutlineOffMicroscope()
    {
        foreach (var partMicroscope in partsOfMicroscopeOutline)
        {
            partMicroscope.enabled = false;
        }
    }
    void GetMicroscopeOutline()
    {
        var partsMicroscopeObject = GameObject.FindGameObjectsWithTag("microscope");
        for (int i = 0; i < 29; i++)
        {
            partsOfMicroscopeOutline[i] = partsMicroscopeObject[i].GetComponent<Outline>();
        }
    }
}
