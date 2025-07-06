namespace AssetTool
{
    [JsonAsset("RemoteControlPresetActor")]
    public class ARemoteControlPresetActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}