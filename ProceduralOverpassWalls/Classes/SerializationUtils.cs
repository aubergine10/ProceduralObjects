﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Text;

namespace ProceduralObjects.Classes
{
    public static class SerializationUtils
    {
        public static Vector3 ToVector3(this SerializableVector3 source)
        {
            return new Vector3(source.x, source.y, source.z);
        }
        public static Quaternion ToQuaternion(this SerializableQuaternion source)
        {
            return new Quaternion(source.x, source.y, source.z, source.w);
        }
        public static SerializableColor ToColor(this SerializableQuaternion source)
        {
            return new SerializableColor(source.x, source.y, source.z, source.w);
        }
        public static string ToFileName(this string s)
        {
            return s.Replace(" ", "_").Replace(@"\", "").Replace("/", "").Replace("|", "").Replace("<", "").Replace(">", "").Replace("*", "").Replace(":", "").Replace("?", "").Replace("\"", "");
        }
    }
}
