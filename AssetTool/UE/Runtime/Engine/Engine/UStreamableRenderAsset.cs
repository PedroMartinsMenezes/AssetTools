namespace AssetTool
{
    public class UStreamableRenderAsset : UObject
    {
        public UStreamableRenderAsset Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}
