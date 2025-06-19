namespace AssetTool
{
    [JsonAsset("InterchangeSceneImportAsset")]
    public class UInterchangeSceneImportAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}