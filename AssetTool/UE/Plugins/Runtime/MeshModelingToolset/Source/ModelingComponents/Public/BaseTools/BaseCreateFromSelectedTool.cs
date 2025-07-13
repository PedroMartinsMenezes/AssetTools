namespace AssetTool
{
    [JsonAsset("BaseCreateFromSelectedToolBuilder")]
    public class UBaseCreateFromSelectedToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BaseCreateFromSelectedHandleSourceProperties")]
    public class UBaseCreateFromSelectedHandleSourceProperties : UOnAcceptHandleSourcesProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BaseCreateFromSelectedCollisionProperties")]
    public class UBaseCreateFromSelectedCollisionProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TransformInputsToolProperties")]
    public class UTransformInputsToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BaseCreateFromSelectedTool")]
    public class UBaseCreateFromSelectedTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}