namespace Pure3D.Chunks
{
    /// <summary>
    /// Parent of <c>CompositeDrawableSkin</c> chunks
    /// </summary>
    [ChunkType(17683)]
    public class CompositeDrawableSkinList(File file, uint type) : Chunk(file, type)
    {
        public uint NumElements;

        public override void ReadHeader(Stream stream, long length)
        {
            NumElements = new BinaryReader(stream).ReadUInt32();
        }

        public override string ToString()
        {
            return $"Composite Drawable Skin List (Elements: {NumElements})";
        }

        public override string ToShortString()
        {
            return $"{NumElements} Composite Drawable Skins";
        }
    }
}