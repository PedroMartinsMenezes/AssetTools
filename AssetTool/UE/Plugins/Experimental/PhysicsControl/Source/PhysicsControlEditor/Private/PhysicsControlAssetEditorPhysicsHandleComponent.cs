namespace AssetTool
{
    [JsonAsset("PhysicsControlAssetEditorPhysicsHandleComponent")]
    public class UPhysicsControlAssetEditorPhysicsHandleComponent : UPhysicsHandleComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}