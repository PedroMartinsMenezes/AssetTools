namespace AssetTool
{
    [JsonAsset("AvaEditorContext")]
    public class UAvaEditorContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}