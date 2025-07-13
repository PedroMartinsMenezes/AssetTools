namespace AssetTool
{
    [JsonAsset("PhysicsControlAssetEditorPhysicsHandleComponent")]
    public class UPhysicsControlAssetEditorPhysicsHandleComponent : UPhysicsHandleComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}