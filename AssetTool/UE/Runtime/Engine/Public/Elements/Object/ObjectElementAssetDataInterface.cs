namespace AssetTool
{
    [JsonAsset("ObjectElementAssetDataInterface")]
    public class UObjectElementAssetDataInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}