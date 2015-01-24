using UnityEngine;
using System.Collections;

public class NavButton : MonoBehaviour
{
    public GameObject to;

    public void Goto()
    {
        StartCoroutine(Transit(gameObject.transform.parent.gameObject, to, false));
    }

    public IEnumerator Transit(GameObject from, GameObject to, bool dir)
{
    var fromRect = from.GetComponent<RectTransform>();
    var toRect = to.GetComponent<RectTransform>();

    int w = (int)fromRect.rect.width;
        
    var ev = GameObject.Find("EventSystem").GetComponent<UnityEngine.EventSystems.EventSystem>();

    ev.enabled = false;
    to.SetActive(true);
    Debug.Log("w " + w);
    Debug.Log("from " + from.transform.localPosition);
    Debug.Log("to " + to.transform.localPosition);
    var pos = fromRect.anchoredPosition;
    int frame = 15;
    for(int i = 0; i < frame; i++) {
        pos.x = (dir?-w:w) * Fomula.EaseIn((float)i / frame);
        Debug.Log("i: " + i + " : " + pos);

        fromRect.anchoredPosition = pos;
        pos.x += dir?w:-w;
        toRect.anchoredPosition = pos;
        yield return null;
    }
    from.SetActive(false);
    ev.enabled = true;
 
}
}
