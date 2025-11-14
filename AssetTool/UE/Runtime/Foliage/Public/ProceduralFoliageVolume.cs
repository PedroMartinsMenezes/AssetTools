namespace AssetTool
{
    [JsonAsset("ProceduralFoliageVolume")]
    public class AProceduralFoliageVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}