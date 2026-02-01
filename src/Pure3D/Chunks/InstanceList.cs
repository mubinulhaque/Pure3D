namespace Pure3D.Chunks
{
    [ChunkType(50331656)]
    public class InstanceList(File file, uint type) : Named(file, type)
    {
        public override void ReadHeader(Stream stream, long length)
        {
            base.ReadHeader(stream, length);
        }

        public override string ToString()
        {
            return $"{ToShortString()}: {Name}";
        }

        public override string ToShortString()
        {
            return "Instance List";
        }
    }
}
