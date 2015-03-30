using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using System.Xml.Linq;
using System.Configuration;

namespace GameFramework2D.IO
{
    public static class FileIO
    {
        public static Dictionary<string, SpriteAnimation> LoadAllAnimations()
        {
            Dictionary<string, SpriteAnimation> AllAnimations = new Dictionary<string,SpriteAnimation>();
            AnimationFrame frame;
            SpriteAnimation animation;
            XDocument document;
            string spriteRectanglePath = ConfigurationManager.AppSettings["DefaultSpriteRectanglesPath"];
            string[] filePaths;
            int fileCount;
            if (Directory.Exists(spriteRectanglePath))
            {
                fileCount = Directory.GetFiles(spriteRectanglePath).Count();
                filePaths = new string[fileCount];
                filePaths = Directory.GetFiles(spriteRectanglePath);
                foreach (string path in filePaths)
                {
                    document = XDocument.Load(path);
                    animation = new SpriteAnimation();
                    foreach (XElement spriteRectangleFrame in document.Root.Nodes())
                    {
                        frame = new AnimationFrame();
                        frame.frameNumber = Convert.ToByte(spriteRectangleFrame.Element("FrameNumber").Value);
                        frame.frameSpritesheet = spriteRectangleFrame.Element("FrameSpritesheet").Value;
                        frame.frameXLocation = Convert.ToInt16(spriteRectangleFrame.Element("FrameXLocation").Value);
                        frame.frameYLocation = Convert.ToInt16(spriteRectangleFrame.Element("FrameYLocation").Value);
                        frame.frameWidth = Convert.ToInt16(spriteRectangleFrame.Element("GridFrameWidth").Value);
                        frame.frameHeight = Convert.ToInt16(spriteRectangleFrame.Element("GridFrameHeight").Value);
                        frame.SetAnimationFrameAlignment(path);
                        animation.AddAnimationFrame(frame);
                    }
                    AllAnimations.Add(path.Substring(path.LastIndexOf('\\') + 1, path.LastIndexOf('.') - path.LastIndexOf('\\') - 1), animation);
                }

                return AllAnimations;
            }
            else
            {
                return null;
            }
            
        }

        public static bool ReadSaveFile()
        {

            return false;
        }

        public static bool WriteSaveFile()
        {

            return false;
        }
    }
}
