namespace AssetTool
{
    [JsonAsset("MetaHumanEditorSettings")]
    public class UMetaHumanEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}