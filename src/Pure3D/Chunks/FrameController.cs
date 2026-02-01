using System.Text;

namespace Pure3D.Chunks
{
    [ChunkType(1184256)]
    public class FrameController(File file, uint type) : VersionNamed(file, type)
    {
        public string Value;
        public uint FrameOffset;
        public string HierarchyName;
        public string AnimName;

        public override void ReadHeader(System.IO.Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            base.ReadHeader(stream, length);
            Value = Util.ReadString(reader, 4);
            FrameOffset = reader.ReadUInt32();
            HierarchyName = Util.ReadString(reader);
            AnimName = Util.ReadString(reader);
        }

        public override string ToString()
        {
            return $"Frame Controller: {Name}, Version {Version}";
        }

        public override string ToShortString()
        {
            return "Frame Controller";
        }
    }
}