using System.IO;
using System.Text;

namespace Pure3D.Chunks
{
    /// <summary>
    /// Parent of an <c>AnimationGroupList</c>
    /// and an <c>AnimationSize</c>.
    /// </summary>
    [ChunkType(1183744)]
    public class AnimationChunk(File file, uint type) : VersionNamed(file, type)
    {
        public string AnimType;
        public float NumberOfFrames;
        public float FrameRate;
        public uint Looping;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            base.ReadHeader(stream, length);
            AnimType = Util.ReadString(reader, 4);
            NumberOfFrames = reader.ReadSingle();
            FrameRate = reader.ReadSingle();
            Looping = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"Animation: {Name}, Version: {Version}, {NumberOfFrames} Frames, Framerate: {FrameRate}, Looping: {Looping}";
        }

        public override string ToShortString()
        {
            return "Animation";
        }
    }
}