namespace AssetTool
{
    [Location("void USimpleConstructionScript::Serialize(FArchive& Ar)")]
    public class USimpleConstructionScript : UObject
    {
        public const string TypeName = "SimpleConstructionScript";

        public USimpleConstructionScript Read(BinaryReader reader)
        {
            base.Move(GlobalObjects.Transfer);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            base.Move(GlobalObjects.Transfer);
        }
    }
}
