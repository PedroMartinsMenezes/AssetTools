namespace AssetTool
{
    [JsonAsset("TestSettings")]
    public class UTestSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}