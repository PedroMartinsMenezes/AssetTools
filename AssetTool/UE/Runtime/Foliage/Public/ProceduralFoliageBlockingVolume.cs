namespace AssetTool
{
    [JsonAsset("ProceduralFoliageBlockingVolume")]
    public class AProceduralFoliageBlockingVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}