namespace AssetTool
{
    [JsonAsset("RemoteControlPresetActorFactory")]
    public class URemoteControlPresetActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}