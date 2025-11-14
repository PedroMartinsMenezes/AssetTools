namespace AssetTool
{
    [JsonAsset("AvaPostProcessVolume")]
    public class AAvaPostProcessVolume : APostProcessVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}