namespace AssetTool
{
    [JsonAsset("RemoteControlTrackerComponent")]
    public class URemoteControlTrackerComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}