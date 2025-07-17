namespace AssetTool
{
    [JsonAsset("AsyncAction_ListenForGameplayMessage")]
    public class UAsyncAction_ListenForGameplayMessage : UCancellableAsyncAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}