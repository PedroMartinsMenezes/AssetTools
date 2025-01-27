namespace AssetTool
{
    [JsonAsset("InterchangePhysicalCameraFactoryNode")]
    public class UInterchangePhysicalCameraFactoryNode : UInterchangeActorFactoryNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeStandardCameraFactoryNode")]
    public class UInterchangeStandardCameraFactoryNode : UInterchangeActorFactoryNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}