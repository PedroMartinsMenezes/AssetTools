namespace AssetTool
{
    [JsonAsset("GenericSmartObject")]
    public class AGenericSmartObject : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}