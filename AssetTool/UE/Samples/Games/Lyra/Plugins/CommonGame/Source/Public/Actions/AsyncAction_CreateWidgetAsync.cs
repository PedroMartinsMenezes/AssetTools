namespace AssetTool
{
    [JsonAsset("AsyncAction_CreateWidgetAsync")]
    public class UAsyncAction_CreateWidgetAsync : UCancellableAsyncAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}