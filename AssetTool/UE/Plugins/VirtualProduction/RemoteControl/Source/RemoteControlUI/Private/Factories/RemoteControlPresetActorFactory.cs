namespace AssetTool
{
    [JsonAsset("RemoteControlPresetActorFactory")]
    public class URemoteControlPresetActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}