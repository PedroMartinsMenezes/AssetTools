namespace AssetTool
{
    [JsonAsset("CutMeshWithMeshToolProperties")]
    public class UCutMeshWithMeshToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CutMeshWithMeshTool")]
    public class UCutMeshWithMeshTool : UBaseCreateFromSelectedTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CutMeshWithMeshToolBuilder")]
    public class UCutMeshWithMeshToolBuilder : UBaseCreateFromSelectedToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}