namespace AssetTool
{
    [JsonAsset("DefaultAssetEditorGizmoFactory")]
    public class UDefaultAssetEditorGizmoFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}