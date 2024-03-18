namespace AssetTool
{
    [Location("void UBlueprintGeneratedClass::Serialize(FArchive& Ar)")]
    public class UBlueprintGeneratedClass : UClass
    {
        public const string TypeName = "BlueprintGeneratedClass";

        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }

        public new UBlueprintGeneratedClass Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
    }
}
