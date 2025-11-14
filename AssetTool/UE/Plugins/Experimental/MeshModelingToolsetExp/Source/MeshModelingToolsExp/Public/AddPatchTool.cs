namespace AssetTool
{
    [JsonAsset("AddPatchToolBuilder")]
    public class UAddPatchToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AddPatchToolProperties")]
    public class UAddPatchToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AddPatchTool")]
    public class UAddPatchTool : USingleClickTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}