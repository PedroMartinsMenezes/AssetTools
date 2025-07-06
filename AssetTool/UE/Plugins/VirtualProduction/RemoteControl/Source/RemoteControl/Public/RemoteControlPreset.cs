namespace AssetTool
{
    [JsonAsset("RemoteControlPreset")]
    public class URemoteControlPreset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}