namespace AssetTool
{
    [JsonAsset("Selection")]
    public class USelection : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}