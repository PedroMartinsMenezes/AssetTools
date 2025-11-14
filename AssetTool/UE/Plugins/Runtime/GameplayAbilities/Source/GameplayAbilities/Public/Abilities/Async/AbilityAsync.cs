namespace AssetTool
{
    [JsonAsset("AbilityAsync")]
    public class UAbilityAsync : UCancellableAsyncAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}