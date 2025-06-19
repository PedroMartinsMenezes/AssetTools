namespace AssetTool
{
    [JsonAsset("InterchangeSceneNode")]
    public class UInterchangeSceneNode : UInterchangeBaseNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}