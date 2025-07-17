namespace AssetTool
{
    [JsonAsset("AsyncAction_ObserveTeam")]
    public class UAsyncAction_ObserveTeam : UCancellableAsyncAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}