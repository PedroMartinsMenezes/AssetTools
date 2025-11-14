namespace AssetTool
{
    [JsonAsset("ScriptTestActor")]
    public class AScriptTestActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}