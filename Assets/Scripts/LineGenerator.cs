using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{
    public GameObject redLineGen, blueLineGen, pinkLineGen, greenLineGen;
    
    public string currentColor;

    Line line;

    public GameObject number;

    private void Start()
    {
        currentColor = "blue";
    }

    private void Update()
    {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Vector3 linePos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
                GameObject actualLine = Instantiate(blueLineGen, linePos, transform.rotation, number.transform);
                if (currentColor == "red")
            {
                actualLine = Instantiate(redLineGen, linePos, transform.rotation, number.transform);
            }
                else if (currentColor == "pink")
            {
                actualLine = Instantiate(pinkLineGen, linePos, transform.rotation, number.transform);
            }
                else if (currentColor == "green")
            {
                actualLine = Instantiate(greenLineGen, linePos, transform.rotation, number.transform);
            }
                line = actualLine.GetComponent<Line>();
            }

            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                line = null;
            }

            if (line != null)
            {
                Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                line.DrawLine(mousePos);
            }
    }

    public void Red()
    {
        currentColor = "red";
    }

    public void Blue()
    {
        currentColor = "blue";
    }

    public void Pink()
    {
        currentColor = "pink";
    }

    public void Green()
    {
        currentColor = "green";
    }
}
