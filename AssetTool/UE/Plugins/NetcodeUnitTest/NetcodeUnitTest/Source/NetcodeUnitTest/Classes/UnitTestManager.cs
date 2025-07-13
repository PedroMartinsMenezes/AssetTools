namespace AssetTool
{
    [JsonAsset("UnitTestManager")]
    public class UUnitTestManager : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}