namespace AssetTool
{
    [JsonAsset("Workspace")]
    public class UWorkspace : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}