namespace AssetTool
{
    [JsonAsset("StatePerObjectConfig")]
    public class UStatePerObjectConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}