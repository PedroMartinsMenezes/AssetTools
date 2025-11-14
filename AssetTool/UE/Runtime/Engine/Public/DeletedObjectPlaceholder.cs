namespace AssetTool
{
    [JsonAsset("DeletedObjectPlaceholder")]
    public class UDeletedObjectPlaceholder : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}