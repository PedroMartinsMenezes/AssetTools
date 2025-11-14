namespace AssetTool
{
    [JsonAsset("UnitTestChannel")]
    public class UUnitTestChannel : UChannel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}