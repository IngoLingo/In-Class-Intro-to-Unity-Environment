using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variablesandoperators : MonoBehaviour
{
    // Varables for the below equasions
    private float pi        = 3.1415f;
    private float radius    = 3f;
    private float length    = 5f;
    private float width     = 10f;
    private float baseT     = 6f;
    private float height    = 6f;


    // Use this for initialization
    void Start()
    {
        //Finding diameter, circumference, ect of a circle
        float diameter = 2f * radius;
        float circumference = 2f * pi * radius;
        float areaCircle = pi * (radius * radius);
        float volumeSphere = 1.333f * pi * (radius * radius * radius);

        //Finding the perimeter and area of a rectangle
        float perimeterRectangle = 2f * (length * width);
        float areaRectangle = length * width;

        //Find the area of a triangle
        float areaTriangle = 0.5f * (baseT * height);

        // This is printing everything out!
        print("If you have a radius of " + radius + ", your diameter becomes " + diameter + ".");
        print("If you have the same radius, your circumference is " + circumference + ", and your area, " + areaCircle + ".");
        print("If you want to make this 3D. You will have a volume of " + volumeSphere + ".");
        print("If the width was " + width + " and the length was " + length + " your rectangle would have a perimeter of " + perimeterRectangle + " and an area of " + areaRectangle + ".");
        print("If you have a base of " + baseT + " and a height of " + height + " the area of your triangel will become " + areaTriangle + ".");

    }

}