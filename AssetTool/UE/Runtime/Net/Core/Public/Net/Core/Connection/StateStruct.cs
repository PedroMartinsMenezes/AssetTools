namespace AssetTool
{
    [JsonAsset("StatePerObjectConfig")]
    public class UStatePerObjectConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}