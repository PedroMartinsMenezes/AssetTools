namespace AssetTool
{
    [JsonAsset("InputRouter")]
    public class UInputRouter : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}