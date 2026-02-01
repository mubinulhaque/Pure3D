namespace Pure3D.Chunks
{
    [ChunkType(17689)]
    public class CompositeDrawableSortOrder(File file, uint type) : Chunk(file, type)
    {
        public float SortOrder;

        public override void ReadHeader(Stream stream, long length)
        {
            SortOrder = new BinaryReader(stream).ReadSingle();
        }

        public override string ToString()
        {
            return $"Composite Drawable Sort Order ({SortOrder})";
        }

        public override string ToShortString()
        {
            return "Composite Drawable Sort Order";
        }
    }
}