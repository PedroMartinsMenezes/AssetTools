namespace AssetTool
{
    [JsonAsset("GenericSmartObject")]
    public class AGenericSmartObject : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}