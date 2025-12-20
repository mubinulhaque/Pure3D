using System.IO;

namespace Pure3D.Chunks
{
    [ChunkType(131074)]
    public class AnimatedObjectAnimation(File file, uint type) : VersionNamed(file, type)
    {
        public float FrameRate;
        public uint NumberOfFrameControllers;

        public override void ReadHeader(Stream stream, long length)
        {
            base.ReadHeader(stream, length);
            BinaryReader reader = new(stream);

            FrameRate = reader.ReadSingle();
            NumberOfFrameControllers = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"Animated Object Animation: {Name} ({NumberOfFrameControllers} Frame Controllers, Version: {Version})";
        }

        public override string ToShortString()
        {
            return $"Animated Object Animation";
        }
    }
}
