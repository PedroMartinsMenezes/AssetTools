namespace AssetTool
{
    [JsonAsset("TargetingPreset")]
    public class UTargetingPreset : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}