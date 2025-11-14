namespace AssetTool
{
    [JsonAsset("BaseScriptableToolBuilder")]
    public class UBaseScriptableToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomScriptableToolBuilderComponentBase")]
    public class UCustomScriptableToolBuilderComponentBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomScriptableToolBuilderContainer")]
    public class UCustomScriptableToolBuilderContainer : UBaseScriptableToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomScriptableToolBuilder")]
    public class UCustomScriptableToolBuilder : UCustomScriptableToolBuilderComponentBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScriptableToolTargetRequirements")]
    public class UScriptableToolTargetRequirements : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ToolTargetScriptableToolBuilder")]
    public class UToolTargetScriptableToolBuilder : UCustomScriptableToolBuilderComponentBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}