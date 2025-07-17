namespace AssetTool
{
    [JsonAsset("AsyncAction_ObserveTeamColors")]
    public class UAsyncAction_ObserveTeamColors : UCancellableAsyncAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}