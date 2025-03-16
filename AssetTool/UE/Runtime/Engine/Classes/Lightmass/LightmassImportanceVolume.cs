namespace AssetTool
{
    [JsonAsset("LightmassImportanceVolume")]
    public class ALightmassImportanceVolume : AVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}