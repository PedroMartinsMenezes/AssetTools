namespace AssetTool
{
    [JsonAsset("AsyncAction_PushContentToLayerForPlayer")]
    public class UAsyncAction_PushContentToLayerForPlayer : UCancellableAsyncAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}