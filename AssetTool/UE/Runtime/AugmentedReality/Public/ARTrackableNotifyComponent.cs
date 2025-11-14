namespace AssetTool
{
    [JsonAsset("ARTrackableNotifyComponent")]
    public class UARTrackableNotifyComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}