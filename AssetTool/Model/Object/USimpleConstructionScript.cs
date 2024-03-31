namespace AssetTool
{
    [Location("void USimpleConstructionScript::Serialize(FArchive& Ar)")]
    public class USimpleConstructionScript : UObject
    {
        public const string TypeName = "SimpleConstructionScript";

        public USimpleConstructionScript Read(BinaryReader reader)
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
