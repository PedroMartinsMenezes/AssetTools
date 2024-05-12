namespace AssetTool
{
    [Location("void UUserDefinedStructEditorData::Serialize(FArchive& Ar)")]
    public class UUserDefinedStructEditorData : UObject
    {
        public const string TypeName = "UserDefinedStructEditorData";

        public UUserDefinedStructEditorData Read(BinaryReader reader)
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
