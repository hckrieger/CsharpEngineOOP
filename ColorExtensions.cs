using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class ColorExtensions
    {
        //Color extension that gives a collider box for each pixel
        public static Rectangle BoundingBox(this Color color, Vector2 location, Vector2 origin, int index, int textureWidth, int rectangleWidth = 1, int rectangleHeight = 1)
        {
            int xPos = index % textureWidth;
            int yPos = index / textureWidth;

            Rectangle box = new Rectangle(xPos, yPos, rectangleWidth, rectangleHeight);
            box.Offset(location - origin);
            return box;

        }
    }
}
