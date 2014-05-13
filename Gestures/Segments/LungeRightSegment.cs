using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;

namespace Fizbin.Kinect.Gestures.Segments
{
    public class LungeRightSegment : IRelativeGestureSegment
    {
        public GesturePartResult CheckGesture(Skeleton skeleton)
        {
            if (skeleton.Joints[JointType.KneeLeft].Position.Y < skeleton.Joints[JointType.KneeRight].Position.Y
                && skeleton.Joints[JointType.KneeLeft].Position.Z > skeleton.Joints[JointType.KneeRight].Position.Z)
            {
                return GesturePartResult.Succeed;
            }
            return GesturePartResult.Fail;
        }
    }
}
