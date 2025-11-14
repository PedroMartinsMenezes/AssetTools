namespace AssetTool
{
    [JsonAsset("InterchangeSkeletalMeshActorFactory")]
    public class UInterchangeSkeletalMeshActorFactory : UInterchangeActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}