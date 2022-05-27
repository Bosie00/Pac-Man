using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public float time = 0.1f;
    public Sprite[] frames;
    public int i=0;

    private void Awake() {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Animate), this.time, this.time);
    }

    private void Animate() {
        this.i++;
        if(spriteRenderer.enabled == false) {
            return;
        }

        if (i>=frames.Length || time<0) {
            i =0;
        }
        spriteRenderer.sprite = frames[i];

    }
}
