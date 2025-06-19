namespace AssetTool
{
    [JsonAsset("AvaPostProcessVolume")]
    public class AAvaPostProcessVolume : APostProcessVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}