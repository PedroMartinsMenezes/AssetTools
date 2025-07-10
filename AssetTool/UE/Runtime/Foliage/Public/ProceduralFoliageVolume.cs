namespace AssetTool
{
    [JsonAsset("ProceduralFoliageVolume")]
    public class AProceduralFoliageVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}