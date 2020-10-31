// Copyright 2020 Connor Andrew Ngo
// Licensed under the MIT License

namespace Auios.Rectangle
{
    public struct Rectangle
    {
        public readonly float X;
        public readonly float Y;
        public readonly float Width;
        public readonly float Height;
        public readonly float Top => Y;
        public readonly float Bottom => Y + Height;
        public readonly float Left => X;
        public readonly float Right => X + Width;
        public readonly float HalfWidth => Width * 0.5f;
        public readonly float HalfHeight => Height * 0.5f;
        public readonly float CenterX => X + HalfWidth;
        public readonly float CenterY => Y + HalfHeight;

        public Rectangle(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public bool Contains(float x, float y)
        {
            if (x < Left || x > Right) return false;
            if (y < Top|| y > Bottom) return false;
            return true;
        }
    }
}
