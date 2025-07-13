namespace AssetTool
{
    [JsonAsset("LocalFogVolume")]
    public class ALocalFogVolume : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}