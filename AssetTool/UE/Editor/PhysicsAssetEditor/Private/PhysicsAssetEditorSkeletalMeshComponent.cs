namespace AssetTool
{
    [JsonAsset("PhysicsAssetEditorSkeletalMeshComponent")]
    public class UPhysicsAssetEditorSkeletalMeshComponent : UDebugSkelMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}