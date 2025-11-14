namespace AssetTool
{
    [JsonAsset("AsyncAction_ListenForGameplayMessage")]
    public class UAsyncAction_ListenForGameplayMessage : UCancellableAsyncAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}