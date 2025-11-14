namespace AssetTool
{
    [JsonAsset("LightmassImportanceVolume")]
    public class ALightmassImportanceVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}