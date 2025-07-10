namespace AssetTool
{
    [JsonAsset("FoliageType")]
    public class UFoliageType : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}