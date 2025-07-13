namespace AssetTool
{
    [JsonAsset("CustomizableSkeletalMeshActor")]
    public class ACustomizableSkeletalMeshActor : ASkeletalMeshActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}