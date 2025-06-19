namespace AssetTool
{
    [JsonAsset("LightmassImportanceVolume")]
    public class ALightmassImportanceVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}