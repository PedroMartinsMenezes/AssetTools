namespace AssetTool
{
    [JsonAsset("Workspace")]
    public class UWorkspace : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}