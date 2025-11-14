namespace AssetTool
{
    [JsonAsset("ARBaseAsyncTaskBlueprintProxy")]
    public class UARBaseAsyncTaskBlueprintProxy : UBlueprintAsyncActionBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARSaveWorldAsyncTaskBlueprintProxy")]
    public class UARSaveWorldAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ARGetCandidateObjectAsyncTaskBlueprintProxy")]
    public class UARGetCandidateObjectAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}