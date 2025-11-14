namespace AssetTool
{
    [JsonAsset("CustomizableSkeletalMeshActor")]
    public class ACustomizableSkeletalMeshActor : ASkeletalMeshActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}