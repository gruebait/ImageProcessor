﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SobelEdgeFilter.cs" company="James South">
//   Copyright (c) James South.
//   Licensed under the Apache License, Version 2.0.
// </copyright>
// <summary>
//   The Sobel operator filter.
//   <see href="http://en.wikipedia.org/wiki/Sobel_operator" />
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ImageProcessor.Imaging.Filters.EdgeDetection
{
    /// <summary>
    /// The Sobel operator filter.
    /// <see href="http://en.wikipedia.org/wiki/Sobel_operator"/>
    /// </summary>
    public class SobelEdgeFilter : I2DEdgeFilter
    {
        /// <summary>
        /// Gets the horizontal gradient operator.
        /// </summary>
        public double[,] HorizontalGradientOperator
        {
            get
            {
                return new double[,]
                {
                    { -1, 0, 1 }, 
                    { -2, 0, 2 }, 
                    { -1, 0, 1 }
                };
            }
        }

        /// <summary>
        /// Gets the vertical gradient operator.
        /// </summary>
        public double[,] VerticalGradientOperator
        {
            get
            {
                return new double[,]
                {
                    { 1, 2, 1 }, 
                    { 0, 0, 0 }, 
                    { -1, -2, -1 }
                };
            }
        }
    }
}
