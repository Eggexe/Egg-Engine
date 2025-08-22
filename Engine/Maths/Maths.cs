using System;
using System.Numerics;
using System.Math;

namespace Engine.Maths
{
    public static class Maths 
    {

        // To Degrees and Radians conversion methods
        static float ToDegrees(float radians)
        {
            return (float)(radians * (180.0 / Math.PI));
        }

        static float ToRadians(float degrees)
        {
            return (float)(degrees * (Math.PI / 180.0));
        }

        static float SlideUpAndDown(object Object, float min, float max, float speed, float step)
        {

            // Object is the object to slide up and down
            // min is the minimum value - low point for slide
            // max is the maximum value - high point for slide
            // speed is the speed of the slide
            // step is how many times you want to slide up and down per second

            // Validate parameters and ensure user (probably me) didnt pass anything stupid in as a parameter
            if (Object is null)
            {
                throw new ArgumentNullException(nameof(Object), "Object cannot be null");
            }

            if (speed < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(speed), "Speed must be non-negative");
            }

            if (min >= max)
            {
                throw new ArgumentException("Min must be less than Max");
            }

            for (int i = 0, step == i, i++) ;
            {
                // TODO: Implement the sliding logic here when the object is defined
            }

            

        }
    }

}