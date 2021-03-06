﻿using Hudl.FFmpeg.BaseTypes;
using Hudl.FFmpeg.Resources.BaseTypes;

namespace Hudl.FFmpeg.Resources
{
    [ContainsStream(Type = typeof(VideoStream))]
    public class Png : BaseContainer
    {
        private const string FileFormat = ".png";

        public Png() 
            : base(FileFormat)
        {
        }
       
        protected override IContainer Clone()
        {
            return new Png();
        }
    }
}
