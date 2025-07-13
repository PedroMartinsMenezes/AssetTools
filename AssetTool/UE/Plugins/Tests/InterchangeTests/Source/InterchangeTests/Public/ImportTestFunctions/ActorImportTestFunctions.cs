namespace AssetTool
{
    [JsonAsset("ActorImportTestFunctions")]
    public class UActorImportTestFunctions : UImportTestFunctionsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}