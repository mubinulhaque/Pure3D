namespace Pure3D.Chunks
{
    /// <summary>
    /// Parent of <c>CompositeDrawableEffect</c> chunks
    /// </summary>
    [ChunkType(17687)]
    public class CompositeDrawableEffectList(File file, uint type) : Chunk(file, type)
    {
        public uint NumElements; // should be # of children.

        public override void ReadHeader(Stream stream, long length)
        {
            NumElements = new BinaryReader(stream).ReadUInt32();
        }

        public override string ToString()
        {
            return $"Composite Drawable Effect List ({NumElements} Elements)";
        }

        public override string ToShortString()
        {
            return $"{NumElements} Composite Drawable Effects";
        }
    }
}