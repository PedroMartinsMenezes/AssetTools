namespace AssetTool
{
    [JsonAsset("PhysicsControlAssetEditorSkeletalMeshComponent")]
    public class UPhysicsControlAssetEditorSkeletalMeshComponent : UDebugSkelMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}