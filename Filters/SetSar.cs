﻿using System;
using Hudl.Ffmpeg.Common;
using Hudl.Ffmpeg.BaseTypes;
using Hudl.Ffmpeg.Filters.BaseTypes;
using Hudl.Ffmpeg.Resources.BaseTypes;

namespace Hudl.Ffmpeg.Filters
{
    /// <summary>
    /// SetSar Filter, sets the Sample Aspect Ratio for the video resource.
    /// </summary>
    [AppliesToResource(Type=typeof(IVideo))]
    public class SetSar : BaseFilter
    {
        private const int FilterMaxInputs = 1;
        private const string FilterType = "setsar";

        public SetSar()
            : base(FilterType, FilterMaxInputs)
        {
        }
        public SetSar(FfmpegRatio ratio)
            : this()
        {
            if (ratio == null)
            {
                throw new ArgumentException("Ratio cannot be null.", "ratio");
            }

            Ratio = ratio;
        }

        public FfmpegRatio Ratio { get; set; } 

        public override string ToString() 
        {
            if (Ratio == null)
            {
                throw new InvalidOperationException("Ratio cannot be null.");
            }

            return string.Concat(Type, "=sar=", Ratio);
        }
    }
}
