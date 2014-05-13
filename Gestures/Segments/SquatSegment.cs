using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;

namespace Fizbin.Kinect.Gestures.Segments
{
    public class SquatSegment : IRelativeGestureSegment
    {
        public GesturePartResult CheckGesture(Skeleton skeleton)
        {
            if (skeleton.Joints[JointType.HipLeft].Position.Y < skeleton.Joints[JointType.KneeLeft].Position.Y || skeleton.Joints[JointType.HipRight].Position.Y < skeleton.Joints[JointType.KneeRight].Position.Y)
            {
                return GesturePartResult.Succeed;
            }
            return GesturePartResult.Fail;
        }
    }
}
