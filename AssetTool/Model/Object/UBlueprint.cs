namespace AssetTool
{
    [Location("void UBlueprint::Serialize(FArchive& Ar)")]
    public class UBlueprint : UBlueprintCore
    {
        public const string TypeName = "Blueprint";

        public new UBlueprint Read(BinaryReader reader)
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
