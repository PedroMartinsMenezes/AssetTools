namespace AssetTool
{
    [JsonAsset("PhysicsAssetEditorAnimInstance")]
    public class UPhysicsAssetEditorAnimInstance : UAnimPreviewInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}