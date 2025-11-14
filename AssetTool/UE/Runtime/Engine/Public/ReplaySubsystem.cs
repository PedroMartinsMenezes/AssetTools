namespace AssetTool
{
    [JsonAsset("ReplaySubsystem")]
    public class UReplaySubsystem : UGameInstanceSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}