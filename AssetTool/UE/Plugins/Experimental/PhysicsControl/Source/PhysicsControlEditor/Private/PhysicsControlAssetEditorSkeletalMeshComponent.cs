namespace AssetTool
{
    [JsonAsset("PhysicsControlAssetEditorSkeletalMeshComponent")]
    public class UPhysicsControlAssetEditorSkeletalMeshComponent : UDebugSkelMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}