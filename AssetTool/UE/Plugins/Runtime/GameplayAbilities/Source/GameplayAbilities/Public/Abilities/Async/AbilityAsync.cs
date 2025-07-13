namespace AssetTool
{
    [JsonAsset("AbilityAsync")]
    public class UAbilityAsync : UCancellableAsyncAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}