namespace AssetTool
{
    [JsonAsset("UVProjectionToolBuilder")]
    public class UUVProjectionToolBuilder : USingleTargetWithSelectionToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVProjectionToolEditActions")]
    public class UUVProjectionToolEditActions : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVProjectionToolProperties")]
    public class UUVProjectionToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVProjectionOperatorFactory")]
    public class UUVProjectionOperatorFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVProjectionTool")]
    public class UUVProjectionTool : USingleTargetWithSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}