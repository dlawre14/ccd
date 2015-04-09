using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//This is the root of all objects with health

public abstract class CCD_Obj : MonoBehaviour {

    protected float health_curr;
    public float health_max;

    public GameObject uiPos;

    public Font labelFont;

    private GameObject canvas;
    private GameObject label;

    protected void Start() {
        health_curr = health_max;
        canvas = FindObjectOfType<WorldManager>().overlayCanvas;

        label = new GameObject(gameObject.name + " Label");
        label.transform.SetParent(canvas.GetComponent<RectTransform>());
        Text t = label.AddComponent<Text>();
        label.AddComponent<Outline>();

        t.text = gameObject.name;
        t.font = labelFont;
        t.alignment = TextAnchor.MiddleCenter;

        //TODO: Build healthbar for each character
    }

    protected void Update()
    {
        if (health_curr <= 0)
        {
            Destroy(gameObject);
        }

        Vector3 p = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        label.GetComponent<RectTransform>().position = Camera.main.WorldToScreenPoint(uiPos.transform.position);
    }

    protected void OnDestroy()
    {
        Destroy(label);
    }

    public void TakeDamage(float damage)
    {
        health_curr -= damage;
    }

    public void RestoreDamage(float damage)
    {
        health_curr += damage;
    }
}
