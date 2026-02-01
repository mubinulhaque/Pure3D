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

        /// <summary>
        /// ReadString accessor because Pure3D loves null terminated strings.
        /// </summary>
        public static string ReadString(BinaryReader reader, int strLen)
        {
            string str = Encoding.ASCII.GetString(reader.ReadBytes(strLen));
            str = ZeroTerminate(str);
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

        /// <summary>
        /// Prints a Pure3D Matrix in a readable format
        /// </summary>
        /// <param name="vector">Pure3D Matrix</param>
        /// <returns>String form of Matrix</returns>
        public static string[] PrintMatrix(Pure3D.Matrix matrix)
        {
            return new string[] {
                $"({matrix.M11}, {matrix.M12}, {matrix.M13}, {matrix.M14})",
                $"({matrix.M21}, {matrix.M22}, {matrix.M23}, {matrix.M24})",
                $"({matrix.M31}, {matrix.M32}, {matrix.M33}, {matrix.M34})",
                $"({matrix.M41}, {matrix.M42}, {matrix.M43}, {matrix.M44})"
            };
        }
    }
}
