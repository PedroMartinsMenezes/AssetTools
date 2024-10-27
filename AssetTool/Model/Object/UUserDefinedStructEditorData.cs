namespace AssetTool
{
    [JsonAsset("serDefinedStructEditorData")]
    public class UUserDefinedStructEditorData : UObject
    {
        [Location("void UUserDefinedStructEditorData::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
