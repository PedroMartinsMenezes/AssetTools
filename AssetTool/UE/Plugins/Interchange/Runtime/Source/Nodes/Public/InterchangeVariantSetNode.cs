namespace AssetTool
{
    [JsonAsset("InterchangeVariantSetNode")]
    public class UInterchangeVariantSetNode : UInterchangeBaseNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeSceneVariantSetsNode")]
    public class UInterchangeSceneVariantSetsNode : UInterchangeBaseNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}