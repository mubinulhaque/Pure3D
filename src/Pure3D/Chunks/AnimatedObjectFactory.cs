using System.IO;

namespace Pure3D.Chunks
{
    [ChunkType(131072)]
    public class AnimatedObjectFactory(File file, uint type) : VersionNamed(file, type)
    {
        public string CompositeDrawable;
        public uint NumberOfAnimations;

        public override void ReadHeader(Stream stream, long length)
        {
            base.ReadHeader(stream, length);
            BinaryReader reader = new(stream);
            CompositeDrawable = Util.ReadString(reader);
            NumberOfAnimations = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"Animated Object Factory: {Name} ({NumberOfAnimations} Animations, Version: {Version})";
        }

        public override string ToShortString()
        {
            return $"Animated Object Factory";
        }
    }
}