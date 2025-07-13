namespace AssetTool
{
    [JsonAsset("ARTrackableNotifyComponent")]
    public class UARTrackableNotifyComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}