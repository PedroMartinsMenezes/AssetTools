namespace AssetTool
{
    [JsonAsset("DeletedObjectPlaceholder")]
    public class UDeletedObjectPlaceholder : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}