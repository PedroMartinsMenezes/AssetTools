namespace AssetTool
{
    [JsonAsset("ParametricRetessellateAction")]
    public class UParametricRetessellateAction : UDatasmithCustomActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ParametricRetessellateActionOptions")]
    public class UParametricRetessellateActionOptions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}