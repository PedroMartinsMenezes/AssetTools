namespace AssetTool
{
    [JsonAsset("PhysicsControlAssetEditorAnimInstance")]
    public class UPhysicsControlAssetEditorAnimInstance : UAnimPreviewInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}