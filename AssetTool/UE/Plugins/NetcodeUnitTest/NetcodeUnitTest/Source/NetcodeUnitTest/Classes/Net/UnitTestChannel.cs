namespace AssetTool
{
    [JsonAsset("UnitTestChannel")]
    public class UUnitTestChannel : UChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}