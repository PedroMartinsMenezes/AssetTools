namespace AssetTool
{
    [JsonAsset("RemoteControlTrackerComponent")]
    public class URemoteControlTrackerComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}