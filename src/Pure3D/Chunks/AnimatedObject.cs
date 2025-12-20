using System.IO;

namespace Pure3D.Chunks
{
    [ChunkType(131073)]
    public class AnimatedObject(File file, uint type) : VersionNamed(file, type)
    {
        public string Factory;
        public uint StartAnimation;

        public override void ReadHeader(Stream stream, long length)
        {
            base.ReadHeader(stream, length);
            BinaryReader reader = new(stream);

            Factory = Util.ReadString(reader);
            StartAnimation = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"Animated Object: {Name} (Factory: {Factory}, Version: {Version})";
        }

        public override string ToShortString()
        {
            return $"Animated Object";
        }
    }
}
