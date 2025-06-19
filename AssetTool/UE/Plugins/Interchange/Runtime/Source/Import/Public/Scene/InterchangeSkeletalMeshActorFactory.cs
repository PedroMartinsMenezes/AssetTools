namespace AssetTool
{
    [JsonAsset("InterchangeSkeletalMeshActorFactory")]
    public class UInterchangeSkeletalMeshActorFactory : UInterchangeActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}