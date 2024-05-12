namespace AssetTool
{
    [Location("void UUserDefinedStructEditorData::Serialize(FArchive& Ar)")]
    public class UUserDefinedStructEditorData : UObject
    {
        public const string TypeName = "UserDefinedStructEditorData";

        public new UUserDefinedStructEditorData Move(Transfer transfer) => (UUserDefinedStructEditorData)base.Move(transfer);
    }
}
