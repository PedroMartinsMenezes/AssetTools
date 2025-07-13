namespace AssetTool
{
    [JsonAsset("PhysicsAssetEditorSkeletalMeshComponent")]
    public class UPhysicsAssetEditorSkeletalMeshComponent : UDebugSkelMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}