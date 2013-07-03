﻿using System;
using Hudl.Ffmpeg.Resources.BaseTypes;

namespace Hudl.Ffmpeg.Filters.BaseTypes
{
    public class Filterchain
    {
        /// <summary>
        /// Returns a new instance of the filterchain
        /// </summary>
        /// <typeparam name="TResource">the Type of output for the new filterchain</typeparam>
        public static Filterchain<TResource> FilterTo<TResource>(params IFilter[] filters)
            where TResource : IResource, new()
        {
            return FilterTo(new TResource(), filters);
        }

        /// <summary>
        /// Returns a new instance of the filterchain
        /// </summary>
        /// <typeparam name="TResource">the Type of output for the new filterchain</typeparam>
        public static Filterchain<TResource> FilterTo<TResource>(TResource output, params IFilter[] filters)
            where TResource : IResource
        {
            if (output == null)
            {
                throw new ArgumentNullException("output");
            }

            return new Filterchain<TResource>(output, filters);
        }

    }
}
