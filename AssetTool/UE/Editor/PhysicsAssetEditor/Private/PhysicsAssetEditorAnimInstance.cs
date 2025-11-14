namespace AssetTool
{
    [JsonAsset("PhysicsAssetEditorAnimInstance")]
    public class UPhysicsAssetEditorAnimInstance : UAnimPreviewInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}