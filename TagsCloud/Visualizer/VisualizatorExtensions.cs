﻿using System.Drawing;
using Point = TagsCloudVisualization.Layouter.Point;
using Rectangle = TagsCloudVisualization.Layouter.Rectangle;
using Size = TagsCloudVisualization.Layouter.Size;

namespace TagsCloudVisualization.Visualizator
{
    public static class VisualizatorExtensions
    {
        public static RectangleF ToRectangleF(this Rectangle rectangle)
        {
            var location = ToPointF(rectangle.Center);
            var size = ToSizeF(rectangle.Size);

            return new RectangleF(location, size);
        }

        public static PointF ToPointF(this Point point)
        {
            return new PointF((float) point.X, (float) point.Y);
        }

        public static SizeF ToSizeF(this Size size)
        {
            return new SizeF((float) size.Width, (float) size.Height);
        }
    }
}