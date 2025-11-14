namespace AssetTool
{
    [JsonAsset("UnitTask")]
    public class UUnitTask : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}