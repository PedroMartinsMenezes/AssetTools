namespace AssetTool
{
    [JsonAsset("RemoteControlPreset")]
    public class URemoteControlPreset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}