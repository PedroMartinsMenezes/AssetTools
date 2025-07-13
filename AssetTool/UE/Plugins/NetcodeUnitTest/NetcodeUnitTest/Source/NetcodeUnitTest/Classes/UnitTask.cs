namespace AssetTool
{
    [JsonAsset("UnitTask")]
    public class UUnitTask : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}