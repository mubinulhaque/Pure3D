namespace Pure3D.Chunks
{
    public abstract class GameAttributeParam(File file, uint type) : Chunk(file, type)
    {
        public string Parameter;
        public uint Value;

        public override void ReadHeader(Stream stream, long length)
        {
            BinaryReader reader = new(stream);
            Parameter = Util.ReadString(reader);
            Value = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return $"Game Attribute Parameter ({Parameter}: {Value})";
        }

        public override string ToShortString()
        {
            return "Game Attribute Parameter";
        }
    }

    [ChunkType(73729)]
    public class GameAttributeIntParam(File file, uint type) : GameAttributeParam(file, type)
    {
        public override string ToShortString()
        {
            return "Game Attribute Integer Parameter";
        }
    }
}