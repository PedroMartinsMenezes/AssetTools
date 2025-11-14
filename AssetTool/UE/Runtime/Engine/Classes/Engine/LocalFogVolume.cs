namespace AssetTool
{
    [JsonAsset("LocalFogVolume")]
    public class ALocalFogVolume : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}