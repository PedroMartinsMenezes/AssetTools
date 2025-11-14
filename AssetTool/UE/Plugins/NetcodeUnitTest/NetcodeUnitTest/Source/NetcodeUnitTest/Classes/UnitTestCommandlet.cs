namespace AssetTool
{
    [JsonAsset("UnitTestCommandlet")]
    public class UUnitTestCommandlet : UCommandlet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}