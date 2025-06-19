namespace AssetTool
{
    [JsonAsset("InputRouter")]
    public class UInputRouter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}