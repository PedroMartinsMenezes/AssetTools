namespace AssetTool
{
    [JsonAsset("DefaultWorkspaceSchema")]
    public class UDefaultWorkspaceSchema : UWorkspaceSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}