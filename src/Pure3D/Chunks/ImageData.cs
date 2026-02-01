namespace Pure3D.Chunks
{
    [ChunkType(102402)]
    public class ImageData(File file, uint type) : Chunk(file, type)
    {
        public byte[] Data;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            uint len = reader.ReadUInt32();
            Data = reader.ReadBytes((int)len);
        }

        public override string ToString()
        {
            return $"Image Data (Header: {Data[0]:X} {Data[1]:X} {Data[2]:X} {Data[3]:X}) (Length: {Data.Length})";
        }

        public override string ToShortString()
        {
            return "Image Data";
        }
    }
}