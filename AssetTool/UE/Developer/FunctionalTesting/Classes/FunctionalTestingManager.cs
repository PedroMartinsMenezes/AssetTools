namespace AssetTool
{
    [JsonAsset("FunctionalTestingManager")]
    public class UFunctionalTestingManager : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PhasedAutomationActorBase")]
    public class APhasedAutomationActorBase : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}