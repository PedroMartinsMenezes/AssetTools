namespace AssetTool
{
    [JsonAsset("InterchangePhysicalCameraNode")]
    public class UInterchangePhysicalCameraNode : UInterchangeBaseNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeStandardCameraNode")]
    public class UInterchangeStandardCameraNode : UInterchangeBaseNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}