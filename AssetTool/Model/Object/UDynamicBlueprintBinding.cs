namespace AssetTool
{
    public class UDynamicBlueprintBinding : UObject
    {
        public new UDynamicBlueprintBinding Read(BinaryReader reader)
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
