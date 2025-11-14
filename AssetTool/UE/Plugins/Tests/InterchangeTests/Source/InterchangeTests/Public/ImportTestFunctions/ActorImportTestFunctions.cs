namespace AssetTool
{
    [JsonAsset("ActorImportTestFunctions")]
    public class UActorImportTestFunctions : UImportTestFunctionsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}