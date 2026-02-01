namespace Pure3D.Chunks
{
    [ChunkType(17685)]
    public class CompositeDrawableSkin(File file, uint type) : Named(file, type)
    {
        public uint IsTranslucent;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            base.ReadHeader(stream, length);
            IsTranslucent = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"Composite Drawable Skin: {Name}, Translucent: {IsTranslucent}";
        }

        public override string ToShortString()
        {
            return "Composite Drawable Skin";
        }
    }
}