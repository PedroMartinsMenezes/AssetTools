namespace AssetTool
{
    [JsonAsset("OptimusNode_ConstantValueGeneratorClass")]
    public class UOptimusNode_ConstantValueGeneratorClass : UClass
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusNode_ConstantValue")]
    public class UOptimusNode_ConstantValue : UOptimusNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}