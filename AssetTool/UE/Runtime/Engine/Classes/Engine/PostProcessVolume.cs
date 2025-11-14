namespace AssetTool
{
    [JsonAsset("PostProcessVolume")]
    public class APostProcessVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}