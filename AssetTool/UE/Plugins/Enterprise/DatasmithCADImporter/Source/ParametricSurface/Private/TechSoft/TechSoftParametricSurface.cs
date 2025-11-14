namespace AssetTool
{
    [JsonAsset("TechSoftParametricSurfaceData")]
    public class UTechSoftParametricSurfaceData : UDatasmithParametricSurfaceData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}