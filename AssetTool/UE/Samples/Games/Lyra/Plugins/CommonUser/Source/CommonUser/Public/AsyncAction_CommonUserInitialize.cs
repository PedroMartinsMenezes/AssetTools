namespace AssetTool
{
    [JsonAsset("AsyncAction_CommonUserInitialize")]
    public class UAsyncAction_CommonUserInitialize : UCancellableAsyncAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}