namespace AssetTool
{
    [JsonAsset("DetailsConfig")]
    public class UDetailsConfig : UEditorConfigBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}