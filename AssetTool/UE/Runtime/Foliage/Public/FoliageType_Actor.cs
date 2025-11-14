namespace AssetTool
{
    [JsonAsset("FoliageType_Actor")]
    public class UFoliageType_Actor : UFoliageType
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}