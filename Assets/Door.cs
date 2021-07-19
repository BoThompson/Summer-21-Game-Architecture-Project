using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public Button button;
    private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (button.pressed)
        {
            transform.position = Vector3.SmoothDamp(transform.position,
                                                    endPosition,
                                                    ref velocity,
                                                    1.5f);

        }
        else
        {
            transform.position = Vector3.SmoothDamp(transform.position,
                                                    startPosition,
                                                    ref velocity,
                                                    1.5f);

        }
    }
}
