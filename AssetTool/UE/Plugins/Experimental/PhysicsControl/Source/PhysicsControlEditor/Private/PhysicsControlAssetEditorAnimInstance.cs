namespace AssetTool
{
    [JsonAsset("PhysicsControlAssetEditorAnimInstance")]
    public class UPhysicsControlAssetEditorAnimInstance : UAnimPreviewInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}