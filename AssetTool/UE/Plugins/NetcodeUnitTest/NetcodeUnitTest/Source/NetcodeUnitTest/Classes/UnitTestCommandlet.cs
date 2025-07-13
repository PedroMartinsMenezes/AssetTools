namespace AssetTool
{
    [JsonAsset("UnitTestCommandlet")]
    public class UUnitTestCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}