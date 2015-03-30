using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameFramework2D.IO
{
    public class SpriteAnimation
    {
        public List<AnimationFrame> frames;

        public SpriteAnimation()
        {
            frames = new List<AnimationFrame>();
        }

        public SpriteAnimation(AnimationFrame[] frames)
        {
            for (int i = 0; i < frames.Length; i++)
            {
                this.frames.Add(frames[i]);
            }
        }

        public SpriteAnimation(List<AnimationFrame> frames)
        {
            this.frames = frames;
        }

        public bool AddAnimationFrame(AnimationFrame frame)
        {
            frames.Add(frame);
            return true;
        }

        public bool DeleteAnimationFrame(int frameIndex)
        {
            frames.RemoveAt(frameIndex);
            if (frames[frameIndex] == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteAnimationFrame(AnimationFrame frame)
        {
            if (this.frames.Remove(frame))
            {
                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}
