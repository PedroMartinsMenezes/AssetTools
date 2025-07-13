namespace AssetTool
{
    [JsonAsset("DrawAndRevolveToolBuilder")]
    public class UDrawAndRevolveToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RevolveToolProperties")]
    public class URevolveToolProperties : URevolveProperties
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RevolveOperatorFactory")]
    public class URevolveOperatorFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DrawAndRevolveTool")]
    public class UDrawAndRevolveTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}