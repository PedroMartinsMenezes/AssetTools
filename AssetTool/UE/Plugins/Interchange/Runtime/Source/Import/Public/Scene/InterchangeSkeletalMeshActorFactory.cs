namespace AssetTool
{
    [JsonAsset("InterchangeSkeletalMeshActorFactory")]
    public class UInterchangeSkeletalMeshActorFactory : UInterchangeActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}