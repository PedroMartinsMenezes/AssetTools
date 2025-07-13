namespace AssetTool
{
    [JsonAsset("TechSoftParametricSurfaceData")]
    public class UTechSoftParametricSurfaceData : UDatasmithParametricSurfaceData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}