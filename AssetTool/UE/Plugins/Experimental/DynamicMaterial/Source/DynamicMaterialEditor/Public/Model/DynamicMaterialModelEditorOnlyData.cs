namespace AssetTool
{
    [JsonAsset("DynamicMaterialModelEditorOnlyData")]
    public class UDynamicMaterialModelEditorOnlyData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}