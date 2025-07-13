namespace AssetTool
{
    [JsonAsset("MaterialEditorSettings")]
    public class UMaterialEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}