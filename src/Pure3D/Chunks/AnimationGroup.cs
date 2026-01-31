using System.IO;

namespace Pure3D.Chunks
{
    /// <summary>
    /// Animation of a <c>SkeletonJoint</c>.
    /// </summary>
    [ChunkType(1183745)]
    public class AnimationGroup(File file, uint type) : VersionNamed(file, type)
    {
        public uint NumberOfChannels;
        public uint GroupId;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            base.ReadHeader(stream, length);
            GroupId = reader.ReadUInt32();
            NumberOfChannels = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"Animation Group: {Name}, {NumberOfChannels} Channels, Group {GroupId}";
        }

        public override string ToShortString()
        {
            return "Animation Group";
        }
    }
}