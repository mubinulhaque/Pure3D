using System.IO;
using System.Text;

namespace Pure3D
{
    public sealed class Util
    {
        /// <summary>
        /// ReadString accessor because Pure3D loves null terminated strings.
        /// </summary>
        public static string ReadString(BinaryReader reader)
        {
            byte strLen = reader.ReadByte();
            string str = Encoding.ASCII.GetString(reader.ReadBytes(strLen));
            str = ZeroTerminate(str);
            return str;
        }

            return str;
        }

        public static string ZeroTerminate(string str)
        {
            int length = str.IndexOf(char.MinValue);
            return length != -1 ? str[..length] : str;
        }

        public static Vector2 ReadVector2(BinaryReader reader)
        {
            Vector2 vector = new()
            {
                X = reader.ReadSingle(),
                Y = reader.ReadSingle()
            };

            return vector;
        }

        public static Vector3 ReadVector3(BinaryReader reader)
        {
            Vector3 vector = new()
            {
                X = reader.ReadSingle(),
                Y = reader.ReadSingle(),
                Z = reader.ReadSingle()
            };

            return vector;
        }

        public static Quaternion ReadQuaternion(BinaryReader reader)
        {
            Quaternion vector = new()
            {
                X = reader.ReadSingle(),
                Y = reader.ReadSingle(),
                Z = reader.ReadSingle(),
                W = reader.ReadSingle()
            };

            return vector;
        }

        public static Matrix ReadMatrix(BinaryReader reader)
        {
            Matrix matrix = new()
            {
                M11 = reader.ReadSingle(),
                M12 = reader.ReadSingle(),
                M13 = reader.ReadSingle(),
                M14 = reader.ReadSingle(),
                M21 = reader.ReadSingle(),
                M22 = reader.ReadSingle(),
                M23 = reader.ReadSingle(),
                M24 = reader.ReadSingle(),
                M31 = reader.ReadSingle(),
                M32 = reader.ReadSingle(),
                M33 = reader.ReadSingle(),
                M34 = reader.ReadSingle(),
                M41 = reader.ReadSingle(),
                M42 = reader.ReadSingle(),
                M43 = reader.ReadSingle(),
                M44 = reader.ReadSingle()
            };

            return matrix;
        }
    }
}
