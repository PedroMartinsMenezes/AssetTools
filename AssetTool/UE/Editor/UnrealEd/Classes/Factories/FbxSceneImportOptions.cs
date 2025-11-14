namespace AssetTool
{
    [JsonAsset("FbxSceneImportOptions")]
    public class UFbxSceneImportOptions : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}