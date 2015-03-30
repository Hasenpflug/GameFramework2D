using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameFramework2D.IO
{
    public class AnimationFrame
    {
        public byte frameNumber;
        public string frameSpritesheet;
        public short frameXLocation;
        public short frameYLocation;
        public short frameWidth;
        public short frameHeight;
        public bool isRightFacingFrame;

        public AnimationFrame()
        {
            this.frameNumber = 0;
            this.frameSpritesheet = "";
            this.frameXLocation = 0;
            this.frameYLocation = 0;
            this.frameWidth = 0;
            this.frameHeight = 0;
            this.isRightFacingFrame = false;
            
        }

        public AnimationFrame(byte frameNumber, string frameSpritesheet, short frameXLocation, short frameYLocation, short frameWidth, short frameHeight, bool isRightFacingFrame)
        {
            this.frameNumber = frameNumber;
            this.frameSpritesheet = frameSpritesheet;
            this.frameXLocation = frameXLocation;
            this.frameYLocation = frameYLocation;
            this.frameWidth = frameWidth;
            this.frameHeight = frameHeight;
            this.isRightFacingFrame = isRightFacingFrame;
        }

        public void SetAnimationFrameAlignment(string animationName)
        {
            if (animationName.Substring(animationName.LastIndexOf('_') + 1, 5) == "Right")
            {
                isRightFacingFrame = true;
            }
            else
            {
                isRightFacingFrame = false;
            }
        }
    }
}
