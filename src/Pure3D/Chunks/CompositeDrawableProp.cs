namespace Pure3D.Chunks
{
    [ChunkType(17686)]
    public class CompositeDrawableProp(File file, uint type) : Named(file, type)
    {
        public bool IsTranslucent;
        public uint SkeletonJointID;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            base.ReadHeader(stream, length);
            IsTranslucent = reader.ReadUInt32() == 1;
            SkeletonJointID = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"Composite Drawable Prop: {Name} (Joint: {SkeletonJointID}, Translucent: {IsTranslucent})";
        }

        public override string ToShortString()
        {
            return "Composite Drawable Prop";
        }
    }
}