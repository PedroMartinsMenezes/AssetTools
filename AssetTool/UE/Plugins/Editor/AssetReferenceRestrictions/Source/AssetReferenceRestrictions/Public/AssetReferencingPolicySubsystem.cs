namespace AssetTool
{
    [JsonAsset("AssetReferencingPolicySubsystem")]
    public class UAssetReferencingPolicySubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}