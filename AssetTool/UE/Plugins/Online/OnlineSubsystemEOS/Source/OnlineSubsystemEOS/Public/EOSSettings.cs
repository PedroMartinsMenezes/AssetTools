namespace AssetTool
{
    [JsonAsset("EOSArtifactSettings")]
    public class UDEPRECATED_EOSArtifactSettings : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EOSSettings")]
    public class UEOSSettings : URuntimeOptionsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}