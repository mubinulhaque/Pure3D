namespace Pure3D.Chunks
{
    /// <summary>
    /// Parent of <c>CompositeDrawableProp</c> chunks
    /// </summary>
    [ChunkType(17684)]
    public class CompositeDrawablePropList(File file, uint type) : Chunk(file, type)
    {
        public uint NumElements;

        public override void ReadHeader(Stream stream, long length)
        {
            NumElements = new BinaryReader(stream).ReadUInt32();
        }

        public override string ToString()
        {
            return $"Composite Drawable Prop List (Elements: {NumElements})";
        }

        public override string ToShortString()
        {
            return $"{NumElements} Composite Drawable Props";
        }
    }
}